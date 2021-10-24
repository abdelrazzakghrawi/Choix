namespace Choixfiliere
{
    internal class Option
    {
        internal string nomChoix;
        internal int placesFiliereGLABDASR;
        private object monChoix;
        private int placesFiliere_GL_ABD_ASR;

        public Option()
        {
        }

        public Option(object monChoix, int placesFiliere_GL_ABD_ASR)
        {
            this.monChoix = monChoix;
            this.placesFiliere_GL_ABD_ASR = placesFiliere_GL_ABD_ASR;
        }
    }
}