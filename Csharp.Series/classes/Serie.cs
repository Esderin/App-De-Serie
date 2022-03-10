namespace Csharp.Series{

     public class Serie : EntidadeBase
     {
         //atributos

         private Genero genero {get; set; }

         private string Titulo {get; set; }

         private string Descricao {get; set; } 

         private int Ano {get; set; }      

         //metodos

         public Serie(int id, Genero genero, string titulo, string Descricao, int ano){
             this.id = id;
             this.Genero = genero;
             this.Titulo = titulo;
             this.Descricao = descricao;
             this.Ano = ano;
             this.Excluido = false;
         }  
         
         public override string ToString()
         {

             //enviroment.newline
             string retorno = "";
             retorno += "Gênero: " + this.Genero + Enviroment.NewLine;
             retorno += "Título: " + this.Titulo + Enviroment.NewLine;
             retorno += "Descrição: " + this.Descricao + Enviroment.NewLine;
             retorno += "Ano de Início: " + this.Ano + Enviroment.NewLine;
             retorno += "Excluido: " + this.Excluido;
             return retorno;
         }

         public string retornaTitulo()
         {
             return this.Titulo;
         }

         public int retornaId()
         {
             return this.Id;
         }

        public bool retornaExcluido()
		{
			return this.Excluido;
		}

         public void Excluir(){
             this.Excluido = true;
         }
     }
}