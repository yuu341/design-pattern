using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            BadIdea bad = new BadIdea2_1();

            //継承を使って多態性を持たせている
            //しかし、これは柔軟性がなく、神クラスである。
            //悪いパターン。
            bad.Method1();

            //一方こちらはいいパターン
            //Strategyは好きに注入できる
            //さらにはStrategyのみ抽出して別の場所にもっていくことも出来る
            //結局継承で出来る多態性というのは集約を使ってもできるし、集約のほうがより柔軟で強力である
            GoodIdea good = new GoodIdea(new Strategy2_2());
            good.Strategy.Method1();

            //一応継承と違って途中から別の動作の一部を変更することだってできる
            //継承がこれを行うためにはさらに継承させるぐらいしかないが、それをするとどんどん神クラスに近づく
            //こういう膨れ上がって手が付けられなくなるのを大きな泥団子と呼ぶ。
            //集約は途中で変更することだって可能だが、これもあまりやらないほうがいいと思われる。
            //newする箇所は依存性なので１か所にまとめること
            good.Strategy = new Strategy1();
            good.Strategy.Method1();
        }
    }

}
