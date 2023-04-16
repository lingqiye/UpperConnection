using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UpperConnection.Database
{
    static class MySqldata
    {

        private static MySqlConnection connection = null;

        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <returns></returns>
        public static MySqlConnection Connection()
        {
            //数据库名字
            string Database = "PCB_Data";
            //创建数据库
            string Mysql_createdb = "CREATE DATABASE pcb_data";
            //账号密码登录
            string connectionString = "server=localhost;user id=root;password=123456;Port = 3306;CharacterSet = utf8";
            //判断数据库是不是第一次创建，并且生成表
            bool Create_table = false;



            //数据库已经连接的话就返回
            if (connection != null)
            {
                return connection;
            }


            connection = new MySqlConnection(connectionString);
            connection.Open();

            //判断PCB_Data数据库有没有
            string checkDatabaseQuery = "SELECT COUNT(*) FROM information_schema.schemata WHERE schema_name = 'pcb_data' ";
            MySqlCommand checkDatabaseCommand = new MySqlCommand(checkDatabaseQuery, connection);
            int count = Convert.ToInt32(checkDatabaseCommand.ExecuteScalar());

            if (count > 0)
            {
                //选择该数据库
                connection.ChangeDatabase(Database);
            }
            else
            {
                //如果没有该数据库，就创建数据库

                checkDatabaseCommand = new MySqlCommand(Mysql_createdb, connection);
                checkDatabaseCommand.ExecuteNonQuery();
                Create_table = true;
            }

            //创建工艺文件记录表
            string sql_craft_file = "CREATE TABLE tb_CraftFile (  Id INT NOT NULL AUTO_INCREMENT,  Name VARCHAR(255),  SaveTime DATE,IniFile varchar(255),PRIMARY KEY (Id));";
            //创建异常/故障记录数据表
            string sql_warn = "CREATE TABLE tb_Warning (Id INT NOT NULL AUTO_INCREMENT, Time TIMESTAMP DEFAULT CURRENT_TIMESTAMP, Kind INT, PRIMARY KEY (Id))";
            ////创建统计报表插片统计的数据表
            //string sql_statistics_insert= "CREATE TABLE statistics_insert (insert_id INT NOT NULL AUTO_INCREMENT, insert_day DATE, insert_record VARCHAR(255), PRIMARY KEY (insert_id))";
            //创建统计报表PCB的数据表
            string sql_statistics_pcbdata = "CREATE TABLE tb_PcbData (Id INT NOT NULL AUTO_INCREMENT,Day DATE,Time INT,CraftId INT,InsertNumber INT, PcbNumber INT,PRIMARY KEY(Id))";


            #region 第一次创建表
            if (Create_table == true)
            {
                MySqlCommand command = new MySqlCommand();
                //选择该数据库
                connection.ChangeDatabase(Database);
                command = new MySqlCommand(sql_craft_file, connection);
                command.ExecuteNonQuery();
                command = new MySqlCommand(sql_warn, connection);
                command.ExecuteNonQuery();
                // command = new MySqlCommand(sql_statistics_insert, connection);
                //command.ExecuteNonQuery();
                command = new MySqlCommand(sql_statistics_pcbdata, connection);
                command.ExecuteNonQuery();

            }
            #endregion


            return connection;
        }



        /// <summary>
        /// 关闭数据库
        /// </summary>
        public static void disconnection()
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }
        }


    }
}
