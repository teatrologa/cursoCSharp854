using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriObj001
{
    public class Animal
    {
        private Guid codigo = Guid.NewGuid();
        public string nome;
        public Especie especie;
        public string raca;
        public string cor;
        public Porte porte;
        public decimal peso;
        public DateTime nascimento;
        private List<string> alergias = new List<string>();
        public bool agressivo;
        public char sexo;
        public bool castrado;
        private DateTime dataCadastrado = DateTime.Now;

        public Guid ObterCodigo()
        {
            return this.codigo;
        }

        public DateTime ObterDataCadastro()
        {
            return this.dataCadastrado;
        }

    }
}