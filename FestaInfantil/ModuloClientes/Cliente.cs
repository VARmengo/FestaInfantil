using FestaInfantil.Compartilhado;

namespace FestaInfantil.ModuloClientes
{
    public class Cliente : EntidadeBase
    {
        public int id;
        public string nome;
        public string telefone;
        public string cpf;

        public Cliente(string nome, string telefone, string cpf)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.cpf = cpf;
        }

        public override string ToString()
        {
            return "Id: " + id + " Nome: " + nome + " Telefone: " + telefone + " CPF: " + cpf;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if(string.IsNullOrEmpty(nome))
                erros.Add("O campo 'nome' é obrigatório");     
            
            else if(string.IsNullOrEmpty(telefone))
                erros.Add("O campo 'telefone' é obrigatório");    
            
            else if(string.IsNullOrEmpty(cpf))
                erros.Add("O campo 'cpf' é obrigatório");

            return erros.ToArray();
        }
    }
}
