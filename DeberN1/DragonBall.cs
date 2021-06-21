 namespace DeberN1
 {
     class DragonBall
    {
        public int Habilidad;
        public string nombre;
        public string TipoPersonaje;
        public int Poderes;
        public string sexo;
        public float estatura;
        public string InicioPartida;
        public string SobreNombre;
        public int Peleas;
        public string Frase;

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
 }   
    