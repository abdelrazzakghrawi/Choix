using System;
using System.Collections.Generic;

namespace Choixfiliere
{
     class eleves:Option
{
    private string nom;
    private string prenom;
    private float note;
    public static object MonChoix {get;}
        public eleves():base()
    {

    }
    public eleves(string nom, string prenom, float note, String nomChoix, int placesFiliere_GL_ABD_ASR) : base(MonChoix, placesFiliere_GL_ABD_ASR)
    {
        this.nom = nom;
        this.prenom = prenom;
        this.note = note;

    }
    public eleves(string nom, string prenom, float note)
    {
        this.nom = nom;
        this.prenom = prenom;
        this.note = note;

    }


    public void TraitementOption()
    {
        
        Option GL = new Option();
        GL.nomChoix = "GL";
        Console.Write(" Entrer le nombre des places en GL : \t");
        GL.placesFiliereGLABDASR = int.Parse(Console.ReadLine());

        Option ABD = new Option();
        ABD.nomChoix = "ABD";
        Console.Write(" Entrer le nombre des places en ABD : \t");
        ABD.placesFiliereGLABDASR = int.Parse(Console.ReadLine());

        Option ARS = new Option();
        ARS.nomChoix = "ASR";
        Console.Write("Entrer le nombre des places dans ASR : \t");
        ARS.placesFiliereGLABDASR = int.Parse(Console.ReadLine());
        
        placesFiliereGLABDASR = GL.placesFiliereGLABDASR + ABD.placesFiliereGLABDASR + ARS.placesFiliereGLABDASR;
        Console.WriteLine("\nle nombre  des etudiant de la filière  genie informatiques est : \t" + placesFiliereGLABDASR);
        Console.WriteLine();
        
        var tupleList = new List<Tuple<eleves, String, String, String>>();

        
          for (int i = 0; i < placesFiliereGLABDASR; i++)
           {
             Console.Write("Entre votre nom  \t");
            nom = (Console.ReadLine());
            Console.Write("Entrer votre prenom  \t");
            prenom = (Console.ReadLine());

            try
            {
             Console.Write("Entrer votre note\t");
             note = float.Parse(Console.ReadLine());
            }
             catch (Exception)
            {
           
             Console.WriteLine("Erreur! ");
            }

                     Console.Write("choisissez le premier ASR ou GL ou ABD :  \t");
                     String premeirechoix = Console.ReadLine();
                     Console.Write("choisissez le  deuxieme choix  ASR ou GL ou ABD :  \t");
                     String dexeimechoisx = Console.ReadLine();
                     Console.Write("choisissez le troisieme choix ASR ou GL ou ABD :  \t");
                     String triosiemechoix = Console.ReadLine();
                     Console.WriteLine();

                 eleves etudiant1 = new eleves(nom, prenom, note);
                 var Et1 = Tuple.Create(etudiant1, premeirechoix, dexeimechoisx, triosiemechoix);
                 tupleList.Add(Et1);

        }
        
                   var listGL = new List<eleves>();
                   var listABD = new List<eleves>();
                   var listASR = new List<eleves>();
      

       
        tupleList.Sort((x, y) =>
        {
            int result = y.Item1.note.CompareTo(x.Item1.note);
            return result == 0 ? y.Item2.CompareTo(x.Item2) : result;
        });
        
        for (int i = 0; i < placesFiliereGLABDASR; i++)
        {
            switch (tupleList[i].Item2)
            {
                //GL
                case "GL":
                    if (GL.placesFiliereGLABDASR > listGL.Count)
                    {
                        eleves item1 = tupleList[i].Item1;
                        listGL.Add(item1);
                    }

                    else
                    {
                      switch (tupleList[i].Item3)
                        {
                          case "ABD":
                         if (ABD.placesFiliereGLABDASR > listABD.Count)
                          {
                          eleves item2 = tupleList[i].Item1;
                          listABD.Add(item2);
                          }
                            else
                             {
                         if (tupleList[i].Item4 == "ASR" && ARS.placesFiliereGLABDASR > listASR.Count)
                          {
                           eleves item3 = tupleList[i].Item1;
                           listASR.Add(item3);
                          }
                             }
                           break;

                           case "ASR":
                           if (ARS.placesFiliereGLABDASR > listASR.Count)
                            {
                            eleves item2 = tupleList[i].Item1;
                           listASR.Add(item2);
                            }
                          else
                         {
                            if (tupleList[i].Item4 == "ABD" && ABD.placesFiliereGLABDASR > listABD.Count)
                             {
                             eleves item3 = tupleList[i].Item1;
                             listABD.Add(item3);
                             }
                           }
                         break;
                       }

                    }
                    break;


              //ABD
             case "ABD":
             if (ABD.placesFiliereGLABDASR > listABD.Count)
              {
              eleves item1 = tupleList[i].Item1;
              listABD.Add(item1);
              }
              else
               {

                switch (tupleList[i].Item3)
                 {
                 case "GL":
                 if (GL.placesFiliereGLABDASR > listGL.Count)
                  {
                  eleves item2 = tupleList[i].Item1;
                  listGL.Add(item2);
                  }
                  else
                   {
                   if (tupleList[i].Item4 == "ASR" && ARS.placesFiliereGLABDASR > listASR.Count)
                    {
                    eleves item3 = tupleList[i].Item1;
                    listASR.Add(item3);
                    }
                   }
                   break;

                 case "ASR":
                 if (ARS.placesFiliereGLABDASR > listASR.Count)
                  {
                  eleves item2 = tupleList[i].Item1;
                  listASR.Add(item2);
                  }
                  else
                   {
                    if (tupleList[i].Item4 == "GL" && GL.placesFiliereGLABDASR > listGL.Count)
                     {
                     eleves item3 = tupleList[i].Item1;
                     listGL.Add(item3);
                     }
                   }
                    break;
                 }

               }
                    break;
                    //ASR
                    case "ASR":
             if (ARS.placesFiliereGLABDASR > listASR.Count)
              {
               eleves item1 = tupleList[i].Item1;
               listASR.Add(item1);
              }
             else
              {
              switch (tupleList[i].Item3)
               {
                   case "ABD":
               if (ABD.placesFiliereGLABDASR > listABD.Count)
                {
                eleves item2 = tupleList[i].Item1;
                listABD.Add(item2);
                }
               else
                {
                if (tupleList[i].Item4 == "GL" && GL.placesFiliereGLABDASR > listGL.Count)
                 {
                 eleves item3 = tupleList[i].Item1;
                 listGL.Add(item3);
                 }
                }
                break;

                case "GL":
               if (GL.placesFiliereGLABDASR > listGL.Count)
                {
                eleves item2 = tupleList[i].Item1;
                listGL.Add(item2);
                }
               else
                {
                if (tupleList[i].Item4 == "ABD" && ABD.placesFiliereGLABDASR > listABD.Count)
                 {
                 eleves item3 = tupleList[i].Item1;
                 listABD.Add(item3);
                 }
                }
               break;
               }
              }
             break;
             }
           
         }
        Console.WriteLine("\n\n les etudiants de la filere  GL:");
        Console.WriteLine("\n" + "Nom" + "\t" + "Prenom" + "\t" + "Note");
        foreach (eleves i in listGL)
        {
            Console.WriteLine(i.nom + "\t" + i.prenom + "\t" + i.note);
        }
        Console.WriteLine("\n les etudiants de la filere ABD :");
        Console.WriteLine("\n" + "Nom" + "\t" + "Prenom" + "\t" + "Note");
        foreach (eleves i in listABD)
        {
            Console.WriteLine(i.nom + "\t" + i.prenom + "\t" + i.note);
        }
        Console.WriteLine("\n les etudiants de filere ASR :");
        Console.WriteLine("\n" + "Nom" + "\t" + "Prenom" + "\t" + "Note");
        foreach (eleves i in listASR)
        {
            Console.WriteLine(i.nom + "\t" + i.prenom + "\t" + i.note);
        }
    }

}
}
