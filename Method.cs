using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLinq
{
    public class Method
    {
        Source apple = new Source()
        {
            Name = "apple",
            Color = "red",
            Category = "fruit"
        };

        Source pear = new Source()
        {
            Name = "pear",
            Color = "yellow",
            Category = "fruit"
        };


        Source cherry = new Source()
        {
            Name = "cherry",
            Color = "red",
            Category = "fruit"
        };


        Source banana = new Source()
        {
            Name = "banana",
            Color = "yellow",
            Category = "fruit"
        };

        Source cabbage = new Source()
        {
            Name = "cabbage",
            Color = "yellow",
            Category = "green"
        };


        Source brinjaul = new Source()
        {
            Name = "brinjaul",
            Color = "purple",
            Category = "green"
        };

        /// <summary>
        ///  判断集合中的所有元素是否都是红色
        /// </summary>
        /// <returns>bool</returns>
        public bool TestAll()
        {
            List<Source> listAll = new List<Source>() {apple,pear,cherry,brinjaul,cabbage,banana };
            bool result = listAll.All(a => a.Color == "red");

            return result;
                
        }
        
        /// <summary>
        /// 判断集合中是否存在一个元素是红色
        /// </summary>
        /// <returns>bool</returns>
        public bool TestAny()
        {
            List<Source> listAny = new List<Source>() { apple, pear, cherry, brinjaul, cabbage, banana };
            bool result = listAny.Any(a => a.Color == "red");

            return result;
        }

        /// <summary>
        /// 判断集合中是否包含pear
        /// </summary>
        /// <returns>bool</returns>
        public bool TestContains()
        {
            List<Source> listContains = new List<Source>() { apple, pear, cherry, brinjaul, cabbage, banana };
            bool result = listContains.Contains(pear);

            return result;
        }

        /// <summary>
        /// 判断2个集合的元素是否相同
        /// </summary>
        /// <returns>bool</returns>
        public bool TestSequenceEqual()
        {
            List<Source> list1 = new List<Source>() { apple, pear, cherry };
            List<Source> list2 = new List<Source>() { brinjaul, cabbage, banana };
            bool result = list1.SequenceEqual(list2);
           // bool result1 = list1.SequenceEqual(list1);

            return result;
        }

        /// <summary>
        /// 找出集合中满足条件的元素
        /// </summary>
        /// <returns>List</returns>
        public List<Source> TestWhere()
        {
            List<Source> listWhere = new List<Source>() { apple, pear, cherry, brinjaul, cabbage, banana };
            List<Source> redList = listWhere.Where(w => w.Color == "red").ToList();
            foreach (var red in redList)
            {
                Console.Write(red + " ");
            }

            return redList;
        }

        /// <summary>
        /// 剔除集合中相同的元素
        /// </summary>
        /// <returns></returns>
        public List<Source> TestDistinct()
        {
            List<Source> listDistinct = new List<Source>() {apple,pear,cherry,apple,pear,pear };
            List<Source> distincts = listDistinct.Distinct().ToList();
            foreach (var distinct in distincts)
            {
                Console.Write(distinct.Name);
            }

            return distincts;
        }

        public List<Source> TestTake()
        {
            List<Source> listTake = new List<Source>() { apple, pear, cherry, apple, pear, pear };
            List<Source> takes = listTake.Take(2).ToList();
            foreach (var take in takes)
            {
                Console.WriteLine(take.Name + " ");
            }
            return takes;
        }



    }
}
