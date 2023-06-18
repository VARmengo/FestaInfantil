using FestaInfantil.Compartilhado;

namespace FestaInfantil.ModuloClientes
{
    public class Cliente : EntidadeBase<Cliente>
    {
        public string nome;
        public string telefone;
        public string cpf;

        public Cliente(string nome, string telefone, string cpf)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.cpf = cpf;
        }

        public override void AtualizarInformacoes(Cliente registroAtualizado)
        {
            this.nome = registroAtualizado.nome;
            this.telefone = registroAtualizado.telefone;
            this.cpf = registroAtualizado.cpf;
        }

        public override string ToString()
        {
            return nome;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo 'NOME' é obrigatório");

            else if (string.IsNullOrEmpty(telefone))
                erros.Add("O campo 'TELEFONE' é obrigatório");

            else if (telefone.Length != 11)
                erros.Add("O campo 'TELEFONE' precisa ter 11 dígitos");

            else if (string.IsNullOrEmpty(cpf))
                erros.Add("O campo 'CPF' é obrigatório");

            else if (cpf.Length != 11)
                erros.Add("O campo 'CPF' precisa ter 11 dígitos");

            return erros.ToArray();
        }
    }
}
