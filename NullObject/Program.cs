namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var bad = new BadPatternFactory();
            var sample1 = bad.Create(PatternType.Unknown);

            //悪いパターンは必ず使用する側がNullチェックをしないといけない
            //つまり負担をクライアントに背負わせている。
            //クライアント数が多ければ多いほどこの処理をいたるところに書くことになるし
            //仮にNullの時（生成失敗時）にログを吐くなどする仕様になったら途方に暮れる
            if (sample1 != null)
                sample1.Method();



            var good = new GoodPatternFactory();
            var sample2 = good.Create(PatternType.Unknown);

            //良いパターンは空扱いのインスタンスをクライアントが返却する
            //クライアントはNullチェックをする必要はなくただ呼び出せばよい。
            //中身は大抵何もしないが、なぜこういう結果になったかログを吐いたりしてもよい。
            sample2.Method();
        }

    }

}
