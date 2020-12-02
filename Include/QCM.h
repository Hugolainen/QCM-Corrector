#pragma once

#ifndef _QCM_H_
#define _QCM_H_

#include "ImageNdg.h"
#include "ImageCouleur.h"
#include "ImageDouble.h"
#include "ImageClasse.h"

// Taille de l'image et seuils (travail sur rapports)
#define DEFAULT_PICTURE_HEIGHT				500
#define DEFAULT_PICTURE_WIDTH				300

#define DEFAULT_PICTURE_ANSWERS_BOUNDARY	80
#define DEFAULT_NAME_POS_SHIFT				20

// Seuils par defaut pour detection des surfaces
#define DEFAULT_SURFACE_THRESHOLD_OBJECT	300

// Propriétés images
#define DEFAULT_NB_NDG						255

// Structure contenant les reponses

typedef struct {
	int numeroQuestion;			// Numero de la question actuelle
	bool isLineWrong;			// Indique si ligne actuelle juste ou fausse
	bool reponse_0;				// Reponse 0
	bool reponse_1;				// Reponse 1
	bool reponse_2;				// Reponse 2
	bool reponse_3;				// Reponse 3
}  QUESTION;


class QCM {

	///////////////////////////////////////
private:
	///////////////////////////////////////

	int _CellWidth;						// Largeur cellule de calibration
	int _CellHeigth;					// Hauteur cellule de calibration

	CImageNdg *_PictureSheet;			// Image de reponses aux QCM
	QUESTION*  _AnswerSheet;			// Tableau contenant les reponses réelles du QCM
	std::string _MaskSheetAnswerSheet;	// Masque de dernière copie analysée et reponses réelles du QCM
	int _NbQuestions;					// Nombre de questions du QCM

										/*
										*	CALIBRATION
										*/

	_declspec(dllexport) void InitQuestionSheet(int nbQuestions);								// Initialise le tableau de reponses contenant les reponses juste
	_declspec(dllexport) void AnalyseSheetForCalibration(CImageNdg img);						// Analyse de la feuille pour trouver cellules cochées, et enregistrment comme reference
	_declspec(dllexport) void SetQuestionSheet_i(int i, QUESTION question);						// Enregistre une question dans le tableau de reponses contenant les reponses juste

																								/*
																								*	ANALYSE
																								*/

	_declspec(dllexport) void CompareSheetWithCalibration(QUESTION *questionSheet);			// Compare la feuille envoyée en paramètre avec la calibration


																							/*
																							*	AUTRE
																							*/

	_declspec(dllexport) void CleanImgIHM();

	///////////////////////////////////////
public:
	///////////////////////////////////////

	_declspec(dllexport) QCM(); // Constructeur par défaut
	_declspec(dllexport) ~QCM(); // destructeur par défaut

								 /*
								 *	CALIBRATION
								 */

	_declspec(dllexport) void SetCalibrationSheet(CImageNdg imCalibration);						// Enregistre la feuille de reponses contenant les reponses juste
	_declspec(dllexport) CImageNdg *GetCalibrationSheet();										// Recupere la feuille de reponses contenant les reponses juste
	_declspec(dllexport) QUESTION* GetQuestionSheet();											// Recupere le tableau de reponses contenant les reponses juste

																								/*
																								*	ANALYSE
																								*/

	_declspec(dllexport) void AnalyseSheet(CImageNdg img);										// Analyse de la feuille pour trouver cellules cochées
	_declspec(dllexport) std::string GetCorrection();											// Retourne le string contenant les réponses de la copie corrigée
	_declspec(dllexport) int QCM::GetCandidatNumber(CImageNdg img);								// Retourne le numero du candidat

};


#endif