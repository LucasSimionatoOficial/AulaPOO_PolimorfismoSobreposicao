namespace AulaPOO_PolimorfismoSobreposicao.classes
{
    public class Zero: Player
    {
        private string sword;

        public override string Pular(){
            return $"pulando até {this.velocidade*3}m";
        }
    }
}