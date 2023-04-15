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
            string sql_craft_file = "CREATE TABLE craft_file (  craft_id INT NOT NULL PRIMARY KEY,  craft_name VARCHAR(255),  craft_savetime DATE\r\n);";
            //创建异常/故障记录数据表
            string sql_warn = "CREATE TABLE warning (warn_id INT NOT NULL AUTO_INCREMENT, warn_time TIMESTAMP DEFAULT CURRENT_TIMESTAMP, warn_type VARCHAR(255), warn_content VARCHAR(255), PRIMARY KEY (warn_id))";
            ////创建统计报表插片统计的数据表
            //string sql_statistics_insert= "CREATE TABLE statistics_insert (insert_id INT NOT NULL AUTO_INCREMENT, insert_day DATE, insert_record VARCHAR(255), PRIMARY KEY (insert_id))";
            //创建统计报表PCB的数据表
            string sql_statistics_pcbdata = "CREATE TABLE statistics_pcbdata (pcbdata_id INT NOT NULL AUTO_INCREMENT,pcbdata_day DATE,pcbdata_time INT,pcbdata_craft_name VARCHAR(255), pcbdata_process_number INT,pcbdata_pcb_number INT,pcbdata_insert_efficiency DECIMAL(10,2),pcbdata_process_efficiency DECIMAL(10,2),PRIMARY KEY(pcbdata_id))";


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
