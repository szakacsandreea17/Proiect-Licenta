using Microsoft.Win32;
using System;
using System.IO;
namespace SzakacsAndreea_2023_Licenta
{
    public class AppDialogs
    {
        public static string GetFilePathToOpen(string initialFolder = null)
        {
            // se pregateste o variabila care va returna raspunsul acestei metode
            string filePath = null;

            // se creeaza un nou dialog standard
            OpenFileDialog fileDialog = new OpenFileDialog();

            // se configureaza unele proprietati ale dialogului
            fileDialog.Title = "OPEN FILE";
            fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (initialFolder != null && Directory.Exists(initialFolder))
            {
                fileDialog.InitialDirectory = initialFolder;
            }

            // se precizeaza un filtru pentru lista de fisiere afisate
            string separator = "|";
            fileDialog.Filter = "Graphics| *.jpg; *.jpeg; *.png; *.gif; *.bmp" + separator +
                                "JPEG files(*.jpg; *.jpeg)|*.jpg; *.jpeg" + separator +
                                "PNG files (*.png)|*.png" + separator +
                                "GIF files (*.gif)|*.gif" + separator +
                                "BMP files (*.bmp)|*.bmp" + separator +
                                "ALL files (*.*)|*.*";

            // se precizeaza filtrul implicit prin numarul de ordine (incepand cu 1 !!!)
            fileDialog.FilterIndex = 1;

            // se stabileste ca nu se pot selecta mai multe nume de fisiere
            fileDialog.Multiselect = false;

            // Se afiseaza dialogul si se preia raspunsul utilizatorului (OK sau Cancel).
            // Daca s-a apasat OK, dialogul returneaza 'true', valoare de tip Boolean.
            // Daca utilizatorul a apăsat OK, atunci se preia calea selectata in dialog,
            // iar in caz contrar, rămâne valoarea 'null', setata de la inceput
            if (fileDialog.ShowDialog() == true)
            {
                filePath = fileDialog.FileName;
            }

            return filePath;
        }


        /// <summary>
        /// Se deschide un dialog standard SAVE FILE, cu anumiti parametri.
        /// </summary>
        /// <returns>Calea completa spre fisier (sau "null")</returns>
       /* public static string GetFilePathToSave(string initialFolder = null, string initialFileName = null)
        {
            // se pregateste o variabila care va returna raspunsul acestei metode
            string filePath = null;

            // se creeaza un nou dialog standard
            SaveFileDialog fileDialog = new SaveFileDialog();

            // se configureaza unele proprietati ale dialogului
            fileDialog.Title = "SAVE FILE";
            fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // se determina folderul initial indicat in apelul metodei (daca exista)
            if (initialFolder != null && Directory.Exists(initialFolder))
            {
                // se seteaza folderul initial in dialogul standard
                fileDialog.InitialDirectory = initialFolder;
            }

            // se determina numele fisierului indicat in apelul metodei (daca exista)
            if (initialFileName != null && Path.GetFileName(initialFileName) != null)
            {
                // se seteaza in dialogul standard numele de fisier propus
                fileDialog.FileName = initialFileName;
            }

            // se precizeaza un filtru pentru lista de fisiere afisate
            string separator = "|";
            fileDialog.Filter = "Graphics| *.jpg; *.jpeg; *.png; *.gif; *.bmp" + separator +
                                "JPEG files(*.jpg; *.jpeg)|*.jpg; *.jpeg" + separator +
                                "PNG files (*.png)|*.png" + separator +
                                "GIF files (*.gif)|*.gif" + separator +
                                "BMP files (*.bmp)|*.bmp" + separator +
                                "ALL files (*.*)|*.*";

            // se precizeaza filtrul implicit prin numarul de ordine (incepand cu 1 !!!)
            fileDialog.FilterIndex = 2;

            // Se afiseaza dialogul si se preia raspunsul utilizatorului (OK sau Cancel).
            // Daca s-a apasat OK, dialogul returneaza 'true', valoare de tip Boolean.
            // Daca utilizatorul a apăsat OK, atunci se preia calea selectata in dialog,
            // iar in caz contrar, rămâne valoarea 'null', setata de la inceput
            if (fileDialog.ShowDialog() == true)
            {
                filePath = fileDialog.FileName;
            }

            return filePath;
        }*/
    }
}
