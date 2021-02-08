using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Globals
{
    public struct Elemento
    {
        public string nome;
        public string directory;
    }
    class Class1
    {
        public static void SalvaArchivio(Elemento[] eleCartelle, int num)
        {
            StreamWriter mioFile;
            mioFile = new StreamWriter("archivio");

            for(int x=0; x<num;x++)
            {
                mioFile.WriteLine(eleCartelle[x].nome);
                mioFile.WriteLine(eleCartelle[x].directory);
            }
            mioFile.Close();
            
        }

        public static void CaricaArchivio(Elemento[] eleCartelle, ref int num)
        {
            StreamReader mioFile;
            mioFile = new StreamReader("archivio");

          
            while(mioFile.EndOfStream==false)
            {
                eleCartelle[num].nome = mioFile.ReadLine();
                eleCartelle[num].directory = mioFile.ReadLine();
                num++;
            }
            mioFile.Close();
        }
    }
}
