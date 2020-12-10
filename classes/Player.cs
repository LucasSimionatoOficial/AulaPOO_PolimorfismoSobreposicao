namespace AulaPOO_PolimorfismoSobreposicao.classes
{
    public abstract class Player
    {
        public float velocidade = 20;
        public float pulo = 1;

        public virtual string Correr(){
            return $"Correndo a {this.velocidade}km/h";
        }

        public virtual string Pular(){
            return $"Pulando até {this.pulo}m";
        }
    }
}