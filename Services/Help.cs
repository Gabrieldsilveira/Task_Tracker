using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Tracker.Services
{
    public class Help
    {
        public static void HelpSystem()
        {
            Console.Clear();
            Console.WriteLine
                ($"**** Bem vindo ao sistema de ajuda! ****\n" +
                $"1º - Para adicionar uma tarefa: add [escreva sua tarefa aqui]\n" +
                $"2º - Para modificar uma tarefa: update [2(id da tarefa)] [escreva a tarefa modificada]\n" +
                $"3º - Para modificar o status da tarefa: mark [2(id da tarefa)] [todo; done; in-progress]\n" +
                $"4º - Para listar as tarefas: list; list todo; list done; list in-progress\n" +
                $"5º - Para deletar uma tarefa: delete [2(id da tarefa)]\n");
        }
    }
}
