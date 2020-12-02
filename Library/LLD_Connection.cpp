#include "LLD_Connection.h"

/*
 * Classe dédiée au passage C++ -> C#
 */

LLD_Connection::LLD_Connection()
{
	_QCM = new QCM();
	_IHMpicture = NULL;
	this->_IHMnbData = 0;
	this->_IHMdata.clear();
}

LLD_Connection::~LLD_Connection()
{
	this->CleanImgIHM();
	delete _QCM;
}

void LLD_Connection::CleanImgIHM() {
	if (_IHMpicture != NULL) {
		(*this->_IHMpicture).~CImageCouleur();
		_IHMpicture = NULL;
		this->_IHMdata.clear();
	}
}

void LLD_Connection::ChangeImgIHM(int nbChamps, byte* data, int stride, int nbLig, int nbCol) {
	this->CleanImgIHM();
	this->_IHMnbData = nbChamps;
	this->_IHMdata.resize(nbChamps);
	this->_IHMpicture = new CImageCouleur(nbLig, nbCol);
	byte* pixPtr = (byte*)data;

	for (int y = 0; y < nbLig; y++)			// Remplissage des pixels
	{
		for (int x = 0; x < nbCol; x++)
		{
			this->_IHMpicture->operator()(y, x)[0] = pixPtr[3 * x + 2];
			this->_IHMpicture->operator()(y, x)[1] = pixPtr[3 * x + 1];
			this->_IHMpicture->operator()(y, x)[2] = pixPtr[3 * x];
		}
		pixPtr += stride; // largeur une seule ligne gestion multiple 32 bits
	}
}

void LLD_Connection::LLD_SetCalibrationSheet(int nbChamps, byte* data, int stride, int nbLig, int nbCol) {	// Convertie image C# en ImageNdg, et envoie au QCM
	this->ChangeImgIHM(nbChamps,data,stride,nbLig,nbCol);		// Update de l'image présente dans l'IHM

	CImageNdg imgForQCM(nbLig, nbCol);
	imgForQCM = this->_IHMpicture->plan(3, 0.33, 0.33, 0.33);	// Transformation image couleure de l'IHM en Ndg
	_QCM->SetCalibrationSheet(imgForQCM);						// Envoie au QCM
}

std::string LLD_Connection::LLD_AnalyseSheet(int nbChamps, byte* data, int stride, int nbLig, int nbCol) {
	std::string correction = "Error LLD_connection.cpp";
	this->ChangeImgIHM(nbChamps, data, stride, nbLig, nbCol);	// Update de l'image présente dans l'IHM

	CImageNdg imgForQCM(nbLig, nbCol);
	imgForQCM = this->_IHMpicture->plan(3, 0.33, 0.33, 0.33);	// Transformation image couleure de l'IHM en Ndg

	_QCM->AnalyseSheet(imgForQCM);								// Analyse de la feuille
	correction = _QCM->GetCorrection();							// Recuperation des reponses justes

	return correction;
}

std::string LLD_Connection::LLD_GetCorrection() {
	return _QCM->GetCorrection();
}

int LLD_Connection::LLD_GetCandidatNumber(int nbChamps, byte* data, int stride, int nbLig, int nbCol) {
	this->ChangeImgIHM(nbChamps, data, stride, nbLig, nbCol);	// Update de l'image présente dans l'IHM

	CImageNdg imgForQCM(nbLig, nbCol);
	imgForQCM = this->_IHMpicture->plan(3, 0.33, 0.33, 0.33);	// Transformation image couleure de l'IHM en Ndg

	return _QCM->GetCandidatNumber(imgForQCM);
}