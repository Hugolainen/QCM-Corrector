#pragma once

#include "ImageClasse.h"
#include "ImageNdg.h"
#include "ImageCouleur.h"
#include "ImageDouble.h"
#include "QCM.h"

#include <windows.h>
#include <cstring>

class LLD_Connection
{

		///////////////////////////////////////
		private:
		///////////////////////////////////////

		QCM						*_QCM;				// Classe QCM du Low Level Driver
		int						 _IHMnbData;		// Nb champs Texte de l'IHM
		std::vector<double>		 _IHMdata;			// Champs Texte de l'IHM
		CImageCouleur			*_IHMpicture;		// Image présente dans la fenetre de l'IHM

		void CleanImgIHM();																	// Enleve d'image de l'IHM présente dans la connexion C#/C++
		void ChangeImgIHM(int nbChamps, byte* data, int stride, int nbLig, int nbCol);		// Met à jour l'image de l'IHM présente dans la connexion C#/C++
		std::string LLD_GetCorrection();													// Retourne le string contenant les réponses de la copie corrigée


		///////////////////////////////////////
		public:
		///////////////////////////////////////

		/*
		*	Constructeurs et destructeurs
		*/

		_declspec(dllexport) LLD_Connection();
		_declspec(dllexport) LLD_Connection(int nbChamps, byte* data, int stride, int nbLig, int nbCol);	// Constructeur par image format bmp C#
		_declspec(dllexport) ~LLD_Connection();


		/*
		*	QCM Calibration
		*/

		_declspec(dllexport) void LLD_SetCalibrationSheet(int nbChamps, byte* data, int stride, int nbLig, int nbCol);	// Enregistre la feuille de reponses contenant les reponses juste


		/*
		*	QCM Analyse
		*/

		_declspec(dllexport) std::string LLD_AnalyseSheet(int nbChamps, byte* data, int stride, int nbLig, int nbCol);		// Analyse de la feuille pour trouver cellules cochées
		_declspec(dllexport) int LLD_GetCandidatNumber(int nbChamps, byte* data, int stride, int nbLig, int nbCol);			// Retourne numero du candidat
};

extern "C" _declspec(dllexport) void LLD_SetCalibrationSheet(LLD_Connection *lldConnection, int nbChamps, byte* data, int stride, int nbLig, int nbCol)
{
	lldConnection->LLD_SetCalibrationSheet(nbChamps, data, stride, nbLig, nbCol);
}

extern "C" _declspec(dllexport) void LLD_AnalyseSheet(LLD_Connection *lldConnection, char* correction, int nbQuestionsMax, int nbChamps, byte* data, int stride, int nbLig, int nbCol)
{
	std::string lldCorrection = lldConnection->LLD_AnalyseSheet(nbChamps, data, stride, nbLig, nbCol);
	strcpy_s(correction, nbQuestionsMax, lldCorrection.c_str());
}

extern "C" _declspec(dllexport) int LLD_GetCandidatNumber(LLD_Connection *lldConnection, int nbChamps, byte* data, int stride, int nbLig, int nbCol)
{
	return lldConnection->LLD_GetCandidatNumber(nbChamps, data, stride, nbLig, nbCol);
}

extern "C" _declspec(dllexport) LLD_Connection *LLD_Initialisation()
{
	LLD_Connection *pLLD_Connection = new LLD_Connection();
	return pLLD_Connection;
}


