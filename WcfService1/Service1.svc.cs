using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService1.data;

namespace WcfService1
{
    // メモ: [リファクター] メニューの [名前の変更] コマンドを使用すると、コード、svc、および config ファイルで同時にクラス名 "Service1" を変更できます。
    // 注意: このサービスをテストするために WCF テスト クライアントを起動するには、ソリューション エクスプローラーで Service1.svc または Service1.svc.cs を選択し、デバッグを開始してください。
    public class Service1 : IService1
    {
        public DataClass1 GetData()
        {

            DataClass1 ret = new DataClass1();

            ret.Reportsrc = new Dictionary<int, Reportrec>();
            ret.Reportsrc2 = new List<Reportrec>();

            // create report data
            for (int i = 0; i < 50; i++)
            {
                ret.Reportsrc.Add(i, new Reportrec() { id = i, message = "record=" + i });

                ret.Reportsrc2.Add(new Reportrec() { id = i, message = "22record=" + i });

            }

            return ret;
        }

    }
}
