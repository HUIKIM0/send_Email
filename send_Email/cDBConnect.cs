using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace send_Email
{
    class cDBConnect
    {
        System.Data.OleDb.OleDbConnection _conn;


        // 생성자. 연결 시 DB주소(경로) 따기. DB연결
        public cDBConnect(string strDBPath)
        {
            // DataAdapter는 자동으로 Connection을
            // 핸들링한다. conn.Open() 불필요.
            string connStr = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={strDBPath}";

            _conn = new OleDbConnection(connStr);

        }

        // 쿼리 호출
        // 호출한 곳에서 받은 Query로 작업한 내용 반환
        public DataSet QueryExeCute(string Query)
        {
            // DataSet 객체 생성
            DataSet ds = new DataSet();

            System.Data.OleDb.OleDbDataAdapter adp = new OleDbDataAdapter(Query, _conn);
            adp.Fill(ds);  

            return ds;
        }

        public bool UpdateQuery()
        {
            return true;
        }

    }
}
