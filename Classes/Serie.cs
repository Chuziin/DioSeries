namespace DioBase.Classes
{
    public class Serie : EntidadeBase
    {

        //Atributos
        private Genero Genero { get ; set ; }
       
       private string Titulo { get ; set ; }

       private string Descricao { get ; set ; }

       private int Ano { get ; set ; }

       private bool Excluido { get; set; }
           

           //Métodos

            public Serie(int id, Genero genero, string titulo, string descricao, int ano)
            {
                this.Id = id;
                this.Genero = Genero;
                this.Titulo = titulo;
                this.Descricao = descricao;
                this.Ano = ano;
                this.Excluido = false;
            }

        public override string ToString()
        {
            string retorno = ' ';
            retorno += "Genero: " + this.Genero = Enviromment.NewLine;
            retorno += "Titulo: " + this.Titulo = Enviromment.NewLine;
            retorno += "Descricao: " + this.Descricao = Enviromment.NewLine;
            retorno += "Ano: " + this.Ano = Enviromment.NewLine;

            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        internal int retornaId()
        {

            return this.Id;
        }

        public void Exclui(){
            this.Excluido = true;
        }
    }
}