using System;
using System.Collections.Generic;

namespace HappyAlgorithms
{
    public class WideWidthSearch
    {
        
        public WideWidthSearch()
        {
        }
        public bool SearchQueue(Dictionary<string, string[]> graph)
        {
            var search_queue = new Queue<string>();
            List<string> searched = {};
            AddToQueue(search_queue, "you", graph);
            while (search_queue.Count != 0)
            {
                var person = search_queue.Dequeue();
                if (!searched.Contains(person))
                {
                    if (PersonIsSeller(person))
                    {
                        Console.WriteLine(person + " is а mango seller!");
                        return true;
                    }
                    else
                        AddToQueue(search_queue, person, graph);
                        searched.Add(person);
                }
            }
            return false;
        }
        private Queue<string> AddToQueue(Queue<string> search_queue, string name, Dictionary<string, string[]> graph){
            for (int i = 0; i < graph[name].Length; i++)
            search_queue.Enqueue(graph[name][i]);
            return search_queue;
        }
        private bool PersonIsSeller(string name){
            return name == "claire";
        }
    }
}
/*
 * Поиск в ширину позволяет определить, существует ли путь из А в В.
о Если путь существует, то поиск в ширину находит кратчайший путь.
о Если в вашей задаче требуется найти «кратчайшее Х», попробуйте смо­ делировать свою задачу графом и воспользуйтесь поиском в ширину для ее решения.
о В направленном графе есть стрелки, а отношения действуют в направле­ нии стрелки (Рама-+ Адит означает «Рама должен Адиту»).
о В ненаправленных графах стрелок нет, а отношение идет в обе сторон·ы (Росс - Рэйчел означает «Росс встречается с Рэйчел, а Рэйчел встреча­ ется с Россом».)
о Очереди относятся к категории FIFO («первым вошел, первым вышел»).
о Стек относится к категории LIFO («последним пришел, первым вышел»).
о Людей следует проверять в порядке их добавления в список поиска, поэтому список поиска должен быть оформлен в виде очереди, иначе найденный путь не будет кратчайшим.
о Позаботьтесь о том, чтобы уже прове­ ренный человек не проверялся заново, иначе может возникнуть бесконечный цикл .
 */
