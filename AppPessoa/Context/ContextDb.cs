using AppPessoa.Model;

namespace AppPessoa.Context
{
    public class ContextDb
    {
        public ContextDb() {
            Pessoas = new List<Pessoa>();
        }

        public List<Pessoa>? Pessoas { get; set; }
    }

}
