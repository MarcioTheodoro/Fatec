using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public List<Funcionario> VetF { get; set; }

        public Departamento(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
        public void Admitir(Funcionario f)
        {// o objeto f, pode ser assalariado ou comissionado
            VetF.Add(f);
        }
        public void ListarFuncionarios()
        {
            foreach (var f in VetF)
                f.Mostrar();                
        }
        public void Excluir(int codigo)
        {
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario funcionario = VetF.ElementAt(i);
                if (codigo == funcionario.Codigo)
                {
                    VetF.Remove(funcionario);
                }
            }
        }
        public void MostrarQtdeDependentesFuncionario()
        {
            foreach (var funcionario in VetF)
            {
                Console.WriteLine($"Código: {funcionario.Codigo} \tNome: {funcionario.Nome} \tTotal de Dependentes: {funcionario.CalcularTotalDependentes()}");
            }
        }
        public double CalcularFolha(int diasUteis)
        {
            double folha = 0;
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario funcionario = VetF.ElementAt(i);
                folha += funcionario.CalcularSalario(diasUteis);
            }
            return folha;
        }
    }
}