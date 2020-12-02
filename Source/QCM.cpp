#include <vector>
#include "ImageNdg.h"
#include "ImageCouleur.h"
#include "ImageDouble.h"
#include "ImageClasse.h"
#include "QCM.h"

/*
* Classe dédiée à la gestion du QCM
*/

QCM::QCM() {
	this->_NbQuestions = 0;
	this->_AnswerSheet = NULL;
	this->_PictureSheet = NULL;
	this->_MaskSheetAnswerSheet = "";
}

QCM::~QCM() {
	if (_PictureSheet != NULL)
		free(_PictureSheet);				// Libere image reponses réelles

	if (_AnswerSheet != NULL)
		free(_AnswerSheet);					// Libere QCM reponses réelles

	if (_MaskSheetAnswerSheet != "")
		_MaskSheetAnswerSheet = "";			// Libere QCM reponses du masque
}


/*
*	CALIBRATION
*/

// Enregistre la feuille de reponses contenant les reponses juste
void QCM::SetCalibrationSheet(CImageNdg imCalibration) {
	CleanImgIHM();
	_PictureSheet = new CImageNdg(imCalibration.seuillage("manuel", 0, DEFAULT_NB_NDG / 2));
	AnalyseSheetForCalibration(*_PictureSheet);
}

CImageNdg *QCM::GetCalibrationSheet() {
	return _PictureSheet;
}

// Enregistre le tableau de reponses contenant les reponses juste
void QCM::InitQuestionSheet(int nbQuestions) {
	if (_AnswerSheet != NULL) {											// Si tableau existe deja, suppression de celui-ci
		free(_AnswerSheet);
		_AnswerSheet = NULL;
	}
	_AnswerSheet = (QUESTION*)calloc(nbQuestions, sizeof(QUESTION));	// Allocation nouveau tableau de reponses
	_NbQuestions = nbQuestions;											// Mise à jour du nombre de questions
}

// Enregistre une question dans le tableau de reponses contenant les reponses juste
void QCM::SetQuestionSheet_i(int i, QUESTION question) {
	for (int i = 0; i < _NbQuestions; i++) {  // Enregistrement de la reponse
		_AnswerSheet[i] = question;
	}
}

// Recupere le tableau de reponses contenant les reponses juste
QUESTION *QCM::GetQuestionSheet() {
	return _AnswerSheet;
}

//Analyse de la feuille pour trouver cellules cochées
void QCM::AnalyseSheet(CImageNdg img) {
	CImageNdg *imgCrop = new CImageNdg(img.ROI(((DEFAULT_PICTURE_HEIGHT - DEFAULT_PICTURE_ANSWERS_BOUNDARY) / 2)
		+ DEFAULT_PICTURE_ANSWERS_BOUNDARY, DEFAULT_PICTURE_WIDTH / 2,
		DEFAULT_PICTURE_HEIGHT - DEFAULT_PICTURE_ANSWERS_BOUNDARY, DEFAULT_PICTURE_WIDTH/2 - DEFAULT_NAME_POS_SHIFT));

	CImageClasse imgClasse((*imgCrop).seuillage("manuel", 0, DEFAULT_NB_NDG / 2), "V8");// Creation image classe pour compter chaque cellule	
	std::vector<SIGNATURE_Forme> compConnexes = imgClasse.sigComposantesConnexes(false);		// Extraction composantes connexes
	int nbQuestionsAnswered = 0;

	QUESTION* tempAnswerSheet = (QUESTION*)calloc(_NbQuestions, sizeof(QUESTION));				// Creation d'un tableau de question tampon pour traiter les valeurs de la copie actuelle										

	for (int i = 0; i < _NbQuestions; i++) {													// Parcours de toutes les lignes

		(&tempAnswerSheet[i])->numeroQuestion = i;												// Enregistrement du numero de question

		if (compConnexes.at(i * 4 + 1).surface > DEFAULT_SURFACE_THRESHOLD_OBJECT) {			// Si surface superieure au seuil pour la reponse 0, la case a été cochée
			(&tempAnswerSheet[i])->reponse_0 = true;
			nbQuestionsAnswered++;
		}
		else {
			(&tempAnswerSheet[i])->reponse_0 = false;
		}
		if (compConnexes.at(i * 4 + 2).surface > DEFAULT_SURFACE_THRESHOLD_OBJECT) {			// Si surface superieure au seuil pour la reponse 1, la case a été cochée
			(&tempAnswerSheet[i])->reponse_1 = true;
			nbQuestionsAnswered++;
		}
		else {
			(&tempAnswerSheet[i])->reponse_1 = false;
		}
		if (compConnexes.at(i * 4 + 3).surface > DEFAULT_SURFACE_THRESHOLD_OBJECT) {			// Si surface superieure au seuil pour la reponse 2, la case a été cochée
			(&tempAnswerSheet[i])->reponse_2 = true;
			nbQuestionsAnswered++;
		}
		else {
			(&tempAnswerSheet[i])->reponse_2 = false;
		}
		if (compConnexes.at(i * 4 + 4).surface > DEFAULT_SURFACE_THRESHOLD_OBJECT) {			// Si surface superieure au seuil pour la reponse 3, la case a été cochée
			(&tempAnswerSheet[i])->reponse_3 = true;
			nbQuestionsAnswered++;
		}
		else {
			(&tempAnswerSheet[i])->reponse_3 = false;
			nbQuestionsAnswered++;
		}

		if (nbQuestionsAnswered != 1)															// Si l'eleve a repondu a 0 questions, ou a plusieurs questions en même temps, la ligne est automatiquement fausse
			(&tempAnswerSheet[i])->isLineWrong = false;

	}

	this->CompareSheetWithCalibration(tempAnswerSheet);
	free(tempAnswerSheet);
	free(imgCrop);
}

//Analyse de la feuille pour trouver cellules cochées, et enregistrement comme reference
void QCM::AnalyseSheetForCalibration(CImageNdg img) {

	CImageNdg *imgCrop = new CImageNdg(img.ROI(((DEFAULT_PICTURE_HEIGHT - DEFAULT_PICTURE_ANSWERS_BOUNDARY) / 2)
		+ DEFAULT_PICTURE_ANSWERS_BOUNDARY, DEFAULT_PICTURE_WIDTH / 2,
		DEFAULT_PICTURE_HEIGHT - DEFAULT_PICTURE_ANSWERS_BOUNDARY, DEFAULT_PICTURE_WIDTH/2-DEFAULT_NAME_POS_SHIFT));

	CImageClasse imgClasse(*imgCrop, "V8");													// Creation image classe pour compter chaque cellule		

	std::vector<SIGNATURE_Forme> compConnexes = imgClasse.sigComposantesConnexes(false);	// Extraction composantes connexes
	_NbQuestions = ((int)compConnexes.size() - 1) / 4;										// Enregistrement du nombre de questions totales, qui correspond au nombre de cellules/4			

	this->InitQuestionSheet(_NbQuestions);													// Creation d'un nouveau tableau de question

	for (int i = 0; i < _NbQuestions; i++) {												// Parcours de toutes les lignes
		(&_AnswerSheet[i])->numeroQuestion = i;													// Enregistrement du numero de question
		(&_AnswerSheet[i])->isLineWrong = true;													// Indique que la ligne actuelle est considerée comme juste (logique car feuulle de calibration)

		if (compConnexes.at(i * 4 + 1).surface > DEFAULT_SURFACE_THRESHOLD_OBJECT) {				// Si surface superieure au seuil pour la reponse 0, la case a été cochée
			(&_AnswerSheet[i])->reponse_0 = true;
		}
		else {
			(&_AnswerSheet[i])->reponse_0 = false;
		}
		if (compConnexes.at(i * 4 + 2).surface > DEFAULT_SURFACE_THRESHOLD_OBJECT) {				// Si surface superieure au seuil pour la reponse 1, la case a été cochée
			(&_AnswerSheet[i])->reponse_1 = true;
		}
		else {
			(&_AnswerSheet[i])->reponse_1 = false;
		}
		if (compConnexes.at(i * 4 + 3).surface > DEFAULT_SURFACE_THRESHOLD_OBJECT) {				// Si surface superieure au seuil pour la reponse 2, la case a été cochée
			(&_AnswerSheet[i])->reponse_2 = true;
		}
		else {
			(&_AnswerSheet[i])->reponse_2 = false;
		}
		if (compConnexes.at(i * 4 + 4).surface > DEFAULT_SURFACE_THRESHOLD_OBJECT) {				// Si surface superieure au seuil pour la reponse 3, la case a été cochée
			(&_AnswerSheet[i])->reponse_3 = true;
		}
		else {
			(&_AnswerSheet[i])->reponse_3 = false;
		}

		//printf("%d,%d,%d,%d\n", (&_AnswerSheet[i])->reponse_0, (&_AnswerSheet[i])->reponse_1, (&_AnswerSheet[i])->reponse_2, (&_AnswerSheet[i])->reponse_3);
	}
	free(imgCrop);
}

void QCM::CompareSheetWithCalibration(QUESTION *questionSheet) {
	_MaskSheetAnswerSheet = "";		// Efface le dernier masque utilisé

	for (int i = 0; i < _NbQuestions; i++) {
		if (((&_AnswerSheet[i])->reponse_0 == ((&questionSheet[i])->reponse_0))							// Si les toutes les reponses de la ligne sont bonnes
			&& ((&_AnswerSheet[i])->reponse_1 == ((&questionSheet[i])->reponse_1))
			&& ((&_AnswerSheet[i])->reponse_2 == ((&questionSheet[i])->reponse_2))
			&& ((&_AnswerSheet[i])->reponse_3 == ((&questionSheet[i])->reponse_3)))
		{
			_MaskSheetAnswerSheet = _MaskSheetAnswerSheet + '1';
		}
		else {
			_MaskSheetAnswerSheet = _MaskSheetAnswerSheet + '0';
		}
	}
	_MaskSheetAnswerSheet = _MaskSheetAnswerSheet + '\0';
}

// Retourne la chaine de caractere comprenant le masque des reponses/reponses justes
std::string QCM::GetCorrection() {
	return _MaskSheetAnswerSheet;
}

// Retourne numero du candidat
int QCM::GetCandidatNumber(CImageNdg img) {
	int number = 0;

	CImageNdg *imgCrop = new CImageNdg(img.ROI(DEFAULT_NAME_POS_SHIFT, DEFAULT_PICTURE_WIDTH / 2 + DEFAULT_NAME_POS_SHIFT,
		DEFAULT_NAME_POS_SHIFT + DEFAULT_NAME_POS_SHIFT / 2, (DEFAULT_PICTURE_ANSWERS_BOUNDARY + DEFAULT_NAME_POS_SHIFT) * 2));

	CImageClasse imgClasse((*imgCrop).seuillage("manuel", 0, DEFAULT_NB_NDG / 2), "V8");// Creation image classe pour compter chaque cellule	
	std::vector<SIGNATURE_Forme> compConnexes = imgClasse.sigComposantesConnexes(false);	// Extraction composantes connexes

	for (int i = 0; i < 8; i++) {															// Parcours de toutes les lignes
		if (compConnexes.at(8 - i).surface >= DEFAULT_SURFACE_THRESHOLD_OBJECT) {			// Si surface superieure au seuil, la case a été cochée
			number = number + pow(2, i);														// 2^n pour compter en binaire
		}
	}
	return number;																			// Retourne numero de candidat	
}

void QCM::CleanImgIHM() {
	if (this->_PictureSheet != NULL) {
		(*this->_PictureSheet).~CImageNdg();
		this->_PictureSheet = NULL;
	}
}