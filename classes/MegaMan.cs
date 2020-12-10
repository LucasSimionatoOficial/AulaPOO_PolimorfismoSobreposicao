namespace AulaPOO_PolimorfismoSobreposicao.classes
{
    public class MegaMan: Player
    {
        private string buster;

        public override string Correr(){
            return $"Correndo a {this.velocidade*1.5}km/h";
        }
    }
}