using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMethod
{
    public class Method
    {
        Source apple = new Source()
        {
            Name = "apple",
            Color = "red",
            Category = "fruit",
            Price = 1.1
        };

        Source pear = new Source()
        {
            Name = "pear",
            Color = "yellow",
            Category = "fruit",
            Price = 1.2
        };


        Source cherry = new Source()
        {
            Name = "cherry",
            Color = "red",
            Category = "fruit",
            Price = 1.3
        };


        Source banana = new Source()
        {
            Name = "banana",
            Color = "yellow",
            Category = "fruit",
            Price = 1.4
        };

        Source cabbage = new Source()
        {
            Name = "cabbage",
            Color = "green",
            Category = "vegetable",
            Price = 1.5
        };


        Source brinjaul = new Source()
        {
            Name = "brinjaul",
            Color = "purple",
            Category = "vegetable",
            Price = 1.6
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
        /// <summary>
        /// 根据数量获取元素
        /// </summary>
        /// <returns>list</returns>
        public List<Source> TestTake()
        {
            List<Source> listTake = new List<Source>() { apple, pear, cherry, apple, pear, pear };
            List<Source> takes = listTake.Take(2).ToList();
            foreach (var take in takes)
            {
                Console.Write(take.Name + " ");
            }
            return takes;
        }

        /// <summary>
        /// 找出满足条件的元素
        /// </summary>
        /// <returns>list</returns>
        public List<Source> TestTakeWhile()
        {
            List<Source> listTakeWhile = new List<Source>() { apple, pear, cherry, apple, cabbage, brinjaul };
            List<Source> takeWhiles = listTakeWhile.TakeWhile(t => t.Category == "vegetable").ToList();
            foreach (var takeWhile in takeWhiles)
            {
                Console.Write(takeWhile.Name + " ");
            }
            return takeWhiles;
        }

        /// <summary>
        /// 跳过几个取剩余的元素
        /// </summary>
        /// <returns>list</returns>
        public List<Source> TestSkip()
        {
            List<Source> listSkip = new List<Source>() { apple, pear, cherry, apple, cabbage, brinjaul };
            List<Source> skips = listSkip.Skip(2).ToList();
            return skips;

        }

        /// <summary>
        /// 根据判断条件跳过一些元素
        /// </summary>
        /// <returns>list</returns>
        public List<Source> TestSkipWhile()
        {
            List<Source> listSkipWhile = new List<Source>() { apple, pear, cherry, apple, cabbage, brinjaul };
            List<Source> skipWhiles = listSkipWhile.SkipWhile(s => s.Category == "fruit").ToList();
            return skipWhiles;

        }

        /// <summary>
        /// OrderBy：按根据某个键按升序对序列的元素进行排序。
        /// ThenBy：如果OrderBy的元素相同再按照ThenBy排序。
        /// </summary>
        /// <returns>list</returns>
        public List<Source> TestOrderBy()
        {
            List<Source> listOrderBy = new List<Source>() { apple, pear,cabbage};
            List<Source> oderBys = listOrderBy.OrderBy(o => o.Category).ThenBy(t => t.Color).ToList();

            return oderBys;
        }

        /// <summary>
        /// OrderByDescending：按根据某个键按降序对序列的元素进行排序。
        /// ThenByDescending：如果OrderBy的元素相同再按照ThenBy排序。 
        /// </summary>
        /// <returns></returns>
        public List<Source> TestOrderByDescend()
        {
            List<Source> listOrderByDescend = new List<Source>() { apple, pear, cabbage };
            List<Source> oderBys = listOrderByDescend.OrderByDescending(o => o.Category).ThenByDescending(t => t.Color).ToList();

            return oderBys;
        }

        /// <summary>
        /// 将集合中的元素反转
        /// </summary>
        public void TestReverse()
        {
            List<Source> listReverse = new List<Source>() { apple, pear, cabbage };
            listReverse.Reverse();

        }

        /// <summary>
        /// 取出第一个元素 or 取出按照某种条件的第一个
        /// </summary>
        public void TestFirst()
        {
            List<Source> listFirst = new List<Source>() { apple, pear, cherry, apple, cabbage, brinjaul };
            //Source first = listFirst.First();
            //Source first = listFirst.FirstOrDefault();
            Source first = listFirst.First(f => f.Category == "fruit");
        }

        /// <summary>
        /// 取出最后元素 or 取出按照某种条件的最后一个
        /// </summary>
        public void TestLast()
        {
            List<Source> listLast = new List<Source>() { apple, pear, cherry, apple, cabbage, brinjaul };
            // Source last = listLast.Last();
           // Source last = listLast.LastOrDefault();
            Source last = listLast.Last(l => l.Color == "red");
        }

        /// <summary>
        /// 取出只有一个元素的元素
        /// </summary>
        public void TestSingle()
        {
            List<Source> listSingle = new List<Source>() { apple, pear, cherry, apple, cabbage, brinjaul };
            try
            {
                //Source single = listSingle.Single(s => s.Name == "apple");
                Source single = listSingle.SingleOrDefault(s => s.Name == "apple");
            }
            catch
            {
                Console.WriteLine("Single方法只能取出只有一个元素的情况");
            }

        }

        /// <summary>
        /// 按照索引取出对应的元素
        /// </summary>
        public void TestElementAt()
        {
            List<Source> listElement = new List<Source>() { apple, pear, cherry, apple, cabbage, brinjaul };
            Source element = listElement.ElementAt(3);         
        }

        /// <summary>
        /// 将2个集合合并成一个集合，不排除相同的元素
        /// </summary>
        public void TestConcat()
        {
            List<Source> list1 = new List<Source>() { apple, pear, cherry };
            List<Source> list2 = new List<Source>() { cherry, cabbage, banana };
            List<Source> concats = list1.Concat(list2).ToList();
        }

        /// <summary>
        /// 将2个集合合并成一个集合，排除相同的元素
        /// </summary>
        public void TestUnion()
        {
            List<Source> list1 = new List<Source>() { apple, pear, cherry };
            List<Source> list2 = new List<Source>() { cherry, cabbage, banana };
            List<Source> unions = list1.Union(list2).ToList();
        }

        /// <summary>
        /// 将2个集合中相同元素返回
        /// </summary>
        public void TestIntersect()
        {
            List<Source> list1 = new List<Source>() { apple, pear, cherry };
            List<Source> list2 = new List<Source>() { cherry, cabbage, banana };
            List<Source> intersects = list1.Intersect(list2).ToList();
        }

        /// <summary>
        /// 排除集合1中包含集合2的元素，并且剔除相同的元素
        /// </summary>
        public void TestExcept()
        {
            List<Source> list1 = new List<Source>() { apple, pear, pear,cherry };
            List<Source> list2 = new List<Source>() { cherry, cabbage, banana };
            List<Source> excepts = list1.Except(list2).ToList();
        }

        /// <summary>
        /// 计算集合的长度
        /// </summary>
        public void TestCount()
        {
            List<Source> listCount = new List<Source>() { apple, pear, cherry, cabbage, brinjaul };
            int length = listCount.Count();

        }

        /// <summary>
        /// 取出集合中价格最大的元素的价格
        /// </summary>
        public void TestMax()
        {
            List<Source> listMax = new List<Source>() { apple, pear, cherry, cabbage, brinjaul };
            double max = listMax.Max(m => m.Price);
        }

        /// <summary>
        /// 取出集合中价格最小的元素的价格
        /// </summary>
        public void TestMin()
        {
            List<Source> listMin = new List<Source>() { apple, pear, cherry, cabbage, brinjaul };
            double max = listMin.Min(m => m.Price);
        }

        /// <summary>
        /// 取出集合中元素的价格的总和
        /// </summary>
        public void TestSum()
        {
            List<Source> listSum = new List<Source>() { apple, pear, cherry, cabbage, brinjaul };
            double max = listSum.Sum(s => s.Price);
        }

        /// <summary>
        /// 取出集合中元素的价格的平均值
        /// </summary>
        public void TestAverage()
        {
            List<Source> listAverage = new List<Source>() { apple, pear, cherry, cabbage, brinjaul };
            double max = listAverage.Average(s => s.Price);
        }

        /// <summary>
        /// 从s开始累积，s的值由前面设置
        /// </summary>
        public void TestAggregate()
        {
            List<Source> listAggregate = new List<Source>() { apple, pear, cherry, cabbage, brinjaul };
            double max = listAggregate.Aggregate(1.1,(s,a) => s + a.Price);
        }

        /// <summary>
        /// 将价格挑选出来
        /// </summary>
        public void TestSelect()
        {
            List<Source> listSelect = new List<Source>() { apple, pear, cherry, cabbage, brinjaul };
            List<double> select = listSelect.Select(s => s.Price).ToList();
        }     

        /// <summary>
        /// 将集合中的元素按照Category进行分组
        /// </summary>
        public void TestGroupBy()
        {
            List<Source> listGroupBy = new List<Source>() { apple, pear, cherry, cabbage, brinjaul };
            List<IGrouping<string, Source>> groupBys = listGroupBy.GroupBy(g => g.Category).ToList();
            foreach (var groupBy in groupBys)
            {
                Console.WriteLine(groupBy.Key);
            }
        }

        /// <summary>
        /// 将集合1和集合2中按照color对应起来，然后合并成一个新的元素
        /// </summary>
        public void TestJoin()
        {
            List<Source> list1 = new List<Source>() { apple, pear, pear, cherry };
            List<Source> list2 = new List<Source>() { cherry, cabbage, banana };
            List<Source> joins = list1.Join(list2,x => x.Color, y => y.Color,
                (x,y) => { return new Source {Color = x.Color,Price = x.Price ,Category = y.Category }; }).ToList();
            foreach (var join in joins)
            {
                Console.WriteLine($"Name：{join.Name},Price：{join.Price},Category：{join.Category},Color：{join.Color}");
            }

        }

       
    }
}
