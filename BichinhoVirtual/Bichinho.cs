using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BichinhoVirtual
{
    internal class Bichinho
    {
        public string Nome { get; set; }
        public string Classe { get; set; }
        public string Familia { get; set; }
        public int Idade { get; set; }
        public bool Estado { get; set; }
        public int Caloria { get; set; }
        public int Forca { get; set; }

        public Bichinho(string nome, string classe, string familia, int idade, bool estado, int caloria, int forca)
        {
            Nome = nome;
            Classe = classe;
            Familia = familia;
            Idade = idade;
            Estado = estado;
            Caloria = caloria;
            Forca = forca;
        }

        public Bichinho(string nome, string classe, string familia)
        {
            Nome = nome;
            Classe = classe;
            Familia = familia;
            Idade = 0;
            Estado = true;
            Caloria = 10;
            Forca = 10;
        }

        public string Nasceu() {
            return $"O animal se chama {Nome} é da classe {Classe}, da familia {Familia}, o animal possuí força de {Forca}, caloria de {Caloria} e idade {Idade}";
        }

        public string Morreu()
        {
            Estado = false;
            Forca = 0;
            return $"O bixinho morreu";
        }

        public string Comeu()
        {
            Caloria += 10;
            Forca -= 2;
            return $"O bixinho está com caloria {Caloria} e força {Forca}";
        }

        public string Correr()
        {
            Caloria -= 5;
            Forca -= 5;
            return $"O bixinho está correndo! Agora está com caloria {Caloria} e força {Forca}";
        }

        public string Dormir()
        {
            Caloria -= 2;
            Forca += 10;
            return $"O animal está domingo agora! Agora está com caloria {Caloria} e força {Forca}";
        }
    }
}
