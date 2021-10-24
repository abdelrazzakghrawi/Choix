using System;
using System.Collections.Generic;
using System.Text;

namespace Choixfiliere
{ 
    class StringSplitOptions
    {

        public String monChoix;
        public int placesFiliere_GL_ABD_ASR;



        public StringSplitOptions()
        {

        }
        public StringSplitOptions(String monChoix, int placesFiliere_GL_ABD_ASR)
        {
            this.MomChoix = MomChoix;
            this.placesFiliereGLABDASR = placesFiliere_GL_ABD_ASR;
        }

        public object MomChoix { get; }
        public int placesFiliereGLABDASR { get; private set; }
    }
}

