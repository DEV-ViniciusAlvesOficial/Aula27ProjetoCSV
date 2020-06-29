using System.IO;

namespace Aula27ProjetoCSV
{
    public class Produto
    {

        public int codigo { get; set; }
        public string nome { get; set; }
        public float preco { get; set; }

        private const string PATH = "Database/produto.csv";
   
        public Produto(){
            string Database = PATH.Split('/')[0];
            if (!Directory.Exists(Database)){
                Directory.CreateDirectory(Database);
            }

            //Cria o arquivo caso não exista
              if(!File.Exists(PATH)){
  
                File.Create(PATH).Close();
            }
        }
        public void Cadastrar(Produto prod){
            var linha = new string[] {PrepararLinha(prod)};
            File.AppendAllLines(PATH, linha);
        }



        public string PrepararLinha(Produto p){
            return $"Código = {p.codigo}; Nome = {p.nome}; Preço = {p.preco}";
        }
    }

}
