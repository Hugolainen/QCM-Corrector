using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetInfo_IHM1
{
    class ClassStats
    {
        private List<float> _listNotes;
        private List<string> _listName;
        private string _classeName;
        private float _somme, _moyenne, _min, _max, _mediane, _seuil;
        private double _ecartType;
        private int _echecs, _succes, _nbrCopies;

        // Constructeur
        public ClassStats()
        {
            _listNotes = new List<float>();
            _listName = new List<string>();
            _classeName = "Sans nom";
            _somme = 0;
            _moyenne = 0;
            _min = 0;
            _max = 0;
            _mediane = 0;
            _ecartType = 0;
            _seuil = 0;
            _echecs = 0;
            _succes = 0;
            _nbrCopies = 0;
        }


        // Calculs des différentes valeures statistiques
        private void calculSomme()
        {
            float x = 0;
            for (int i = 0; i < _listNotes.Count(); i++)
            {
                x = x + _listNotes[i];
            }
            _somme = x;
        }

        private void majSomme(float note)
        {
            _somme = _somme + note;
        }

        private void calculMoyenne()
        {
            _moyenne = _somme / _nbrCopies;
        }

        private void calculMediane()
        {
            int medIndex = 0;
            if (_nbrCopies < 2)
                medIndex = 1;
            else
            {
                if (_nbrCopies < 3)
                {
                    medIndex = 2;
                }
                else
                {
                    if ((_nbrCopies % 2) == 0)
                    {
                        medIndex = (_nbrCopies / 2) + 1;
                    }
                    else
                    {
                        medIndex = _nbrCopies / 2;
                    }
                }
            }
            _mediane = _listNotes[medIndex - 1];
        }

        private void calculEcartType()
        {
            float x = 0;
            for (int i = 0; i < _listNotes.Count(); i++)
            {
                x = x + ((_listNotes[i] - _moyenne) * (_listNotes[i] - _moyenne));
            }
            _ecartType = Math.Sqrt(x / _nbrCopies);
        }

        private void calculMin()
        {
            float x = _listNotes[0];
            for (int i = 1; i < _listNotes.Count(); i++)
            {
                if (x > _listNotes[i])
                {
                    x = _listNotes[i];
                }
            }
            _min = x;
        }

        private void calculMax()
        {
            float x = _listNotes[0];
            for (int i = 1; i < _listNotes.Count(); i++)
            {
                if (x < _listNotes[i])
                {
                    x = _listNotes[i];
                }
            }
            _max = x;
        }

        private void pass_fail(float note)
        {
            if (note < _seuil)
            {
                _echecs++;
            }
            else
            {
                _succes++;
            }
            _nbrCopies++;
        }

        private void addNote(float note, string nom)
        {
            if (_nbrCopies == 0)
            {
                _listNotes.Add(note);
                _listName.Add(nom);
            }
            else
            {
                int index = 0;
                for (int i = 0; (i < _nbrCopies) && (note > _listNotes[i]); i++)
                {
                    index++;
                }
                if (index > _listNotes.Count())
                {
                    _listNotes.Add(note);
                    _listName.Add(nom);
                }
                else
                {
                    _listNotes.Insert(index, note);
                    _listName.Insert(index, nom);
                }
            }
        }

        public void majStats()
        {
            calculSomme();
            calculMoyenne();
            calculMediane();
            calculEcartType();
            calculMin();
            calculMax();
        }

        public void majList(float note, string nom)
        {
            addNote(note, nom);
            pass_fail(note);
        }

        // Setter
        public void setClasse(string name)
        {
            _classeName = name;
        }

        public void setMoy(float moyenne)
        {
            _moyenne = moyenne;
        }

        public void setMin(float mini)
        {
            _min = mini;
        }

        public void setMax(float max)
        {
            _max = max;
        }

        public void setMediane(float mediane)
        {
            _mediane = mediane;
        }

        public void setEcartType(double ecartType)
        {
            _ecartType = ecartType;
        }

        public void setSomme(float somme)
        {
            _somme = somme;
        }

        public void setSeuil(float seuil)
        {
            _seuil = seuil;
        }

        public void setEchecs(int echecs)
        {
            _echecs = echecs;
        }

        public void setSucces(int succes)
        {
            _succes = succes;
        }

        public void setNbrCopies(int nbrCopies)
        {
            _nbrCopies = nbrCopies;
        }

        // Getter
        public string getClasseName()
        {
            return _classeName;
        }

        public float getMoy()
        {
            return _moyenne;
        }

        public float getMin()
        {
            return _min;
        }

        public float getMax()
        {
            return _max;
        }

        public float getMediane()
        {
            return _mediane;
        }

        public double getEcartType()
        {
            return _ecartType;
        }

        public float getSomme()
        {
            return _somme;
        }

        public float getSeuil()
        {
            return _seuil;
        }

        public int getEchecs()
        {
            return _echecs;
        }

        public int getSucces()
        {
            return _succes;
        }

        public int getNbrCopies()
        {
            return _nbrCopies;
        }

        public List<float> getListNotes()
        {
            return _listNotes;
        }

        public List<string> getListName()
        {
            return _listName;
        }

        public void reset()
        {
            _listNotes.Clear();
            _listName.Clear();
            _somme = 0;
            _moyenne = 0;
            _min = 0;
            _max = 0;
            _mediane = 0;
            _seuil = 0;
            _ecartType = 0;
            _echecs = 0;
            _succes = 0;
            _nbrCopies = 0;
        }
    }
}
