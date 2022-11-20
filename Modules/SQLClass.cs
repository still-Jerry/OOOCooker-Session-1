using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
namespace ООО__Поваренок_.Modules
{
    class SQLClass
    {
        public static MySqlConnection Connect()
        {
            try
            {
                String connectionString = "host=localhost; uid=root; pwd=root; database=trade1";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connectionString;
                con.Open();
                return con;
            }
            catch (Exception ex){
                //MessageBox.Show(ex.Message, "Ошибка");
                MessageBox.Show("Невозможно подключиться к базе данных.", "Ошибка");
                return null;
            }
        }
        public static List<string> SelectUser(string login, string pwd, List<string> userinfo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM trade1.user where UserLogin= '" + login + "' and UserPassword = '" + pwd + "';", Connect());
                MySqlDataReader reader = cmd.ExecuteReader();
                userinfo.Clear();
               
                while (reader.Read())
                {
                    userinfo.Add(reader[0].ToString());
                    userinfo.Add(reader[1].ToString());
                    userinfo.Add(reader[2].ToString());
                    userinfo.Add(reader[3].ToString());
                    userinfo.Add(reader[4].ToString());
                    userinfo.Add(reader[5].ToString());
                    userinfo.Add(reader[6].ToString());
                  
                }
                cmd.Connection.Close();
                return userinfo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");

                MessageBox.Show("Невозможно получить данные о пользователе", "Ошибка");
                return userinfo; 
            }
        }

        public static void SelectProduct(
            List<String> ProductArticleNumber, List<String> ProductName,
            List<String> ProductDescription, List<String> ProductPhoto, List<Decimal> ProductCost,
            List<Int32> ProductDiscountAmount, List<String> ProductManufacturer,
            string SearchText, string filter, string Discount)
        {
            try
            {

                string cmd = "SELECT ProductArticleNumber, ProductName, ProductDescription, ProductPhoto, ProductCost, ProductDiscountAmount, ProductManufacturer FROM trade1.product ";
                if (Discount != "" && SearchText != "")
                {
                    cmd += "Where ProductName like '" + SearchText + "%' and ProductDiscountAmount";
                    switch (Discount)
                    {
                        case (">=15"):
                        case ("<10"):
                            cmd += Discount;
                            break;
                        case ("10-15"):
                            cmd += " >=10 and ProductDiscountAmount<15";
                            break;
                        default:
                            break;

                    }
                }
                else if (SearchText != "")
                {
                    cmd += "Where  ProductName like '" + SearchText + "%'";
                }
                else if  (Discount != ""){
                    switch (Discount) {
                        case ("<10"):
                        case (">=15"):
                            cmd += "Where ProductDiscountAmount " + Discount;
                            break;
                        case ("10-15"):
                            cmd += "Where ProductDiscountAmount >=10 and ProductDiscountAmount<15";
                            break;
                        default:
                            break;
                    }
                }

                if (filter != "")
                {
                    cmd += " Order by ProductCost " + filter;
                }
                MySqlCommand Command = new MySqlCommand(cmd+";", Connect());
                MySqlDataReader reader = Command.ExecuteReader();

                ProductArticleNumber.Clear();
                ProductName.Clear();
                ProductDescription.Clear();
                ProductPhoto.Clear();
                ProductCost.Clear();
                ProductDiscountAmount.Clear();
                ProductManufacturer.Clear();

                while (reader.Read())
                {
                    ProductArticleNumber.Add(reader[0].ToString());
                    ProductName.Add(reader[1].ToString());
                    ProductDescription.Add(reader[2].ToString());
                    ProductPhoto.Add(reader[3].ToString());
                    ProductCost.Add(Math.Round(Convert.ToDecimal(reader[4].ToString()), 2));
                    ProductDiscountAmount.Add(Convert.ToInt32(reader[5].ToString()));
                    ProductManufacturer.Add(reader[6].ToString());

                }
                Command.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
        //Order
        public static int  CountThisProductInOrder(string articl)
        {
            try
            {
                int count = 0;
                string check = "SELECT count(*) FROM trade1.orderproduct where ProductArticleNumber='" + articl + "';";
                MySqlCommand Command = new MySqlCommand(check, Connect());
                MySqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    count = Convert.ToInt32(reader[0]);
                }
                Command.Connection.Close();
                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return -1;
            }
        }
        public static int SelectProductsCountInOrders(string article) {
            try
            {
                int count = CountThisProductInOrder(article) + 1;
                string cmd = "SELECT count FROM trade1.orderproduct where ProductArticleNumber='" + article + "';";
                MySqlCommand Command = new MySqlCommand(cmd, Connect());
                MySqlDataReader reader = Command.ExecuteReader();

                 while (reader.Read())
                {
                    count = Convert.ToInt32(reader[0]);
                }
                
                Command.Connection.Close();
                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return -1;
            }
        }
        public static void AddProductInOrder(string articl)
        {
            try
            {
                string cmd = "INSERT INTO `trade1`.`orderproduct` VALUES (null, '" + articl + "', '1')";
                MySqlCommand Command = new MySqlCommand(cmd, Connect());
                Command.ExecuteNonQuery();
                Command.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }


        }
        public static void UpdateProductInOrder(string article)
        {
            try
            {
                int count = SelectProductsCountInOrders(article) + 1;
              
                if (count > CheckCountInStock(article))
                {
                    MessageBox.Show("К сожалению Вы не можете добавить данный товар к заказам, т.к. его больше нет на складе.", "Информация");
                }
                else
                {
                    string cmd = "UPDATE `trade1`.`orderproduct` SET `Count` = '" + count + "' WHERE `ProductArticleNumber` = '" + article + "';";
                    MySqlCommand Command = new MySqlCommand(cmd, Connect());
                    Command.ExecuteNonQuery();
                    Command.Connection.Close();
                }
            }
            catch(Exception ex ) {
                MessageBox.Show(ex.Message, "Ошибка");

            }
        }
        public static Int32 ChangeCountInOrder(string article, Int32 newcount){
            try
            {
               
                if (newcount > CheckCountInStock(article))
                {
                    MessageBox.Show("К сожалению Вы не можете добавить данный товар к заказам, т.к. его больше нет на складе.", "Информация");
                    return SelectProductsCountInOrders(article);
                }
                else if (newcount == 0)
                {
                    if (DeleteProductInOrder(article))
                    {
                        return 0;
                    }
                    else {
                        return 1;
                    }

                }
                else
                {
                    string cmd = "UPDATE `trade1`.`orderproduct` SET `Count` = '" + newcount + "' WHERE `ProductArticleNumber` = '" + article + "';";
                    MySqlCommand Command = new MySqlCommand(cmd, Connect());
                    Command.ExecuteNonQuery();
                    Command.Connection.Close();
                    return newcount;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return -1;
            }
        }
        public static Boolean DeleteProductInOrder(string article)
        {
            try{
                var result = MessageBox.Show("Вы уверены что хотите удалить продукт из заказа?", "Предупреждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string cmd = " Delete from trade1.orderproduct WHERE `ProductArticleNumber` = '" + article + "';";
                    MySqlCommand Command = new MySqlCommand(cmd, Connect());
                    Command.ExecuteNonQuery();
                    Command.Connection.Close();
                    return true;
                }
                return false;
            }
            catch(Exception ex ) {
                MessageBox.Show(ex.Message, "Ошибка");
                return false;
            }
        }
        public static Boolean OrderIsEmpty() {
            try
            {
                string cmd = "SELECT * FROM trade1.orderproduct;";
                MySqlCommand Command = new MySqlCommand(cmd, Connect());
                MySqlDataReader reader = Command.ExecuteReader();
                int count = 0;
                while(reader.Read()){
                    count = Convert.ToInt32(reader[0]);
                }
                Command.Connection.Close();
                if (count > 0)
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка");
                return false;
            }
        }
        public static int CheckCountInStock(string article)
        {
            try
            {
                int count = 0;
                string cmd = "SELECT ProductQuantityInStock FROM trade1.product where ProductArticleNumber='" + article + "';";
                MySqlCommand Command = new MySqlCommand(cmd, Connect());
                MySqlDataReader reader = Command.ExecuteReader();
                while (reader.Read()) {
                    count = Convert.ToInt32(reader[0]);

                }
                Command.Connection.Close();
                return count;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка");
                return -1;
            }
        
        }
        public static void SelectOrders(List<String> OrderArticleNumber, List<String> OrderName,
            List<String> OrderDescription, List<String> OrderPhoto, List<Decimal> OrderCost,
            List<Int32> OrderDiscountAmount, List<String> OrderManufacturer, List<Int32> countPro)
        {
            try{
                string cmd = "SELECT trade1.product.ProductArticleNumber, ProductName, ProductDescription, ProductPhoto, ProductCost, ProductDiscountAmount, ProductManufacturer, count FROM trade1.product" +
                 " INNER JOIN trade1.orderproduct ON product.ProductArticleNumber = orderproduct.ProductArticleNumber;";
                MySqlCommand Command = new MySqlCommand(cmd + ";", Connect());
                MySqlDataReader reader = Command.ExecuteReader();
                OrderArticleNumber.Clear();
                OrderName.Clear();
                OrderDescription.Clear();
                OrderPhoto.Clear();
                OrderCost.Clear();
                OrderDiscountAmount.Clear();
                OrderManufacturer.Clear();
                countPro.Clear();

                while (reader.Read())
                {
                    OrderArticleNumber.Add(reader[0].ToString());
                    OrderName.Add(reader[1].ToString());
                    OrderDescription.Add(reader[2].ToString());
                    OrderPhoto.Add(reader[3].ToString());
                    OrderCost.Add(Math.Round(Convert.ToDecimal(reader[4].ToString()), 2));
                    OrderDiscountAmount.Add(Convert.ToInt32(reader[5].ToString()));
                    OrderManufacturer.Add(reader[6].ToString());
                    countPro.Add(Convert.ToInt32(reader[7].ToString()));


                }
                Command.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
        //Admin
        public static void SelectProductsInTable(DataGridView DataGrid) {
            try
            {
                string cmd = "SELECT  * FROM trade1.Продукты;";
                MySqlCommand Command = new MySqlCommand(cmd, Connect());
                MySqlDataAdapter adapter = new MySqlDataAdapter(Command);
                Command.ExecuteNonQuery();
                Command.Connection.Close();

                DataTable table = new DataTable();
                adapter.Fill(table);
                DataGrid.DataSource = table;
                DataGrid.Columns[0].Visible = false;

            }
            
            catch (Exception ex)
            {
                CrateViewProduct(DataGrid);
                //MessageBox.Show(ex.Message);
            }
        }
        public static void CrateViewProduct(DataGridView DataGrid)
        {
            try
            {
                string cmd = "CREATE VIEW `Продукты` AS (Select "+
                            "ProductArticleNumber as 'Артикул',"+
                            "ProductName as 'Наименование',"+
                            "ProductDescription as 'Описание',"+
                            "ProductManufacturer as 'Производитель',"+
                            "ProductProvider as 'Поставщик',"+

                            "ProductCost as 'Цена',"+
                            "ProductCategory as 'Категория',"+
                            "ProductQuantityInStock as 'На складе',"+
                            "ProductUnit as 'Ед.Измер.',"+
                            "ProductDiscountAmount as '% скидки',"+
                            "ProductMaxDiscount as 'max % cкидки',"+
                            "ProductPhoto as 'Фотография'"+
                            "from trade1.product);";
                MySqlCommand Command = new MySqlCommand(cmd, Connect());
                MySqlDataAdapter adapter = new MySqlDataAdapter(Command);
                Command.ExecuteNonQuery();
                SelectProductsInTable(DataGrid);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        public static void DeleteSelectedProducts(List <string> articls, DataGridView datagrid){
            try {
                var result = MessageBox.Show("Вы уверены, что хотите удалить выделенные продукты?", "Предупреждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    for (int i = 0; i < articls.Count; i++ )
                    {
                        string cmd = "DELETE FROM `trade1`.`product` WHERE (`ProductArticleNumber` = '" + articls[i] + "');";
                        MySqlCommand Command = new MySqlCommand(cmd, Connect());
                        Command.ExecuteNonQuery();
                        Command.Connection.Close();
                    }
                    articls.Clear();
                    SelectProductsInTable(datagrid);
                    MessageBox.Show("Данные успешно обновлены.", "Информация");
                    
                }
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        
        }
        public static void UpdeateSelectedProduct(string articls, string name,
            string Description,  string Manufacture, string Provider, string Cost, 
            string Category, string StockCount, string Unity, string Discount, string MaxDiscount,
             string Photo, DataGridView datagrid)
        {
            try
            {
                var result = MessageBox.Show("Вы уверены, что хотите изменить данные выделенного продукта?", "Предупреждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string cmd = "UPDATE `trade1`.`product` SET `ProductName` = '"+name+"',"+
                        " `ProductDescription` = '" + Description + "', `ProductCategory` = '" + Category + "'," +
                        " `ProductPhoto` = '" + Photo + "', `ProductManufacturer` = '" + Manufacture + "', " +
                        "`ProductCost` = '" + Cost + "', `ProductQuantityInStock` = '" + StockCount + "', " +
                        "`ProductProvider` = '" + Provider + "', `ProductMaxDiscount` = '" + MaxDiscount + "',"+
                        " `ProductUnit` = '" + Unity + "' WHERE (`ProductArticleNumber` = '" + articls + "');";

                    MySqlCommand Command = new MySqlCommand(cmd, Connect());
                    Command.ExecuteNonQuery();
                    Command.Connection.Close();
                    
                    SelectProductsInTable(datagrid);
                    MessageBox.Show("Данные успешно удалены.", "Информация");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void AddNewProduct(string articls, string name,
            string Description, string Manufacture, string Provider, string Cost,
            string Category, string StockCount, string Unity, string Discount, string MaxDiscount,
             string Photo, DataGridView datagrid)
        {
            try
            {
                var result = MessageBox.Show("Вы уверены, что хотите добавить новый продукт?", "Предупреждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string cmd = "INSERT INTO `trade1`.`product` (`ProductArticleNumber`, `ProductName`,"+
                        " `ProductDescription`, `ProductCategory`, `ProductPhoto`, `ProductManufacturer`, "+
                        "`ProductCost`, `ProductDiscountAmount`, `ProductQuantityInStock`, `ProductProvider`,"+
                        " `ProductMaxDiscount`, `ProductUnit`) VALUES ("+
                        "'"+articls+"', '"+name+"', '"+Description+"', '"+Category+"', '"+Photo+"', '"+Manufacture+"', '"+
                        Cost.Replace(",",".") + "', '" + Discount + "', '" + StockCount + "', '" + Provider + "', '" + MaxDiscount + "', '" + Unity + "');";
                   

                    MySqlCommand Command = new MySqlCommand(cmd, Connect());
                    Command.ExecuteNonQuery();
                    Command.Connection.Close();

                    SelectProductsInTable(datagrid);
                    MessageBox.Show("Данные успешно добавлены.", "Информация");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void SelectCategory(ComboBox combobox) {
            try
            {
                string cmd = "SELECT distinct ProductCategory FROM trade1.product";
                MySqlCommand Command = new MySqlCommand(cmd, Connect());
                MySqlDataReader reader = Command.ExecuteReader();
                while (reader.Read()) {
                    combobox.Items.Add(reader[0]);
                }
                Command.Connection.Close();
                combobox.SelectedIndex = 1;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        public static Boolean CheackUniqArticle(string article)
        {
            try
            {
                string ar = "";
                string cmd = "SELECT * FROM trade1.product where ProductArticleNumber =" + article + ";";
                MySqlCommand Command = new MySqlCommand(cmd, Connect());
                MySqlDataReader reader = Command.ExecuteReader();
                while (reader.Read()) {
                    ar = reader[0].ToString();
                }
                if (ar == "") {
                    Command.Connection.Close();

                    return true;
                }
                Command.Connection.Close();
                return false;

            }
            catch (Exception ex) {
                //MessageBox.Show(ex.Message);
                return false;

            }
        }
        //Maneger 
        public static void SelectUsersForOrders(ComboBox combobox) {
            try
            {
                string cmd = "SELECT concat(UserSurname,' ',UserName,' ',UserPatronymic) FROM trade1.user;";
                MySqlCommand Command = new MySqlCommand(cmd, Connect());
                MySqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    combobox.Items.Add(reader[0]);
                }
                Command.Connection.Close();
                combobox.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void SelectAddress(ComboBox combobox)
        {
            try
            {
                string cmd = "SELECT addres FROM trade1.orderpickuppoint;";
                MySqlCommand Command = new MySqlCommand(cmd, Connect());
                MySqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    combobox.Items.Add(reader[0]);
                }
                Command.Connection.Close();
                combobox.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void SelectStateOrders(ComboBox combobox)
        {
            try
            {
                string cmd = "SELECT distinct OrderStatus FROM trade1.order;";
                MySqlCommand Command = new MySqlCommand(cmd, Connect());
                MySqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    combobox.Items.Add(reader[0]);
                }
                Command.Connection.Close();
                combobox.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SelectOrderssInTable(DataGridView DataGrid)
        {
            try
            {
                string cmd = "SELECT  * FROM trade1.Заказы;";
                MySqlCommand Command = new MySqlCommand(cmd, Connect());
                MySqlDataAdapter adapter = new MySqlDataAdapter(Command);
                Command.ExecuteNonQuery();
                Command.Connection.Close();

                DataTable table = new DataTable();
                adapter.Fill(table);
                DataGrid.DataSource = table;
                DataGrid.Columns[0].Visible = false;

            }

            catch (Exception ex)
            {
                CrateViewOrders(DataGrid);
                //MessageBox.Show(ex.Message);
            }
        }
        public static void CrateViewOrders(DataGridView DataGrid)
        {
            try
            {
                string cmd = "CREATE VIEW `Заказы` AS Select  OrderId, "+
                        "OrderStatus as Статус,"+
                        "OrderDeliveryDate as 'Дата доставки',"+
                        "OrderDate as 'Дата заказа',"+
                        "OrderProduct as 'Состав заказа',"+
                        "kode as 'Код',"+
                        "`orderpickuppoint`.`addres` as 'Адрес',"+
                        " concat(UserSurname,' ',UserName,' ',UserPatronymic) as 'Заказчик'"+
                        " from `order`"+
                        "inner join `trade1`. `orderpickuppoint` "+
                        "on `orderpickuppoint`.`idOrderPickupPoint` = `order`.`OrderPickupPoint`"+
                         "join `trade1`.`user` on `user`.`UserID` = `order`.`User`;";

                MySqlCommand Command = new MySqlCommand(cmd, Connect());
                MySqlDataAdapter adapter = new MySqlDataAdapter(Command);
                Command.ExecuteNonQuery();
                SelectOrderssInTable(DataGrid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void DeleteSelectedOrders(List <string> articls, DataGridView datagrid){
            try {
                var result = MessageBox.Show("Вы уверены, что хотите удалить выделенные заказы?", "Предупреждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    for (int i = 0; i < articls.Count; i++ )
                    {
                        string cmd = "DELETE FROM `trade1`.`order` WHERE (`OrderId` = '" + articls[i] + "');";
                        MySqlCommand Command = new MySqlCommand(cmd, Connect());
                        Command.ExecuteNonQuery();
                        Command.Connection.Close();
                    }
                    articls.Clear();
                    SelectOrderssInTable(datagrid);
                    MessageBox.Show("Данные успешно обновлены.", "Информация");
                    
                }
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        
        }
        public static Boolean CheackArticleInProducts(string article)
           {
               try
               {
                   Int32 ar = 0;
                   string cmd = "SELECT count(*) FROM trade1.product where ProductArticleNumber = '" + article + "';";
                   MySqlCommand Command = new MySqlCommand(cmd, Connect());
                   MySqlDataReader reader = Command.ExecuteReader();
                   while (reader.Read())
                   {
                       ar = Convert.ToInt32(reader[0]);
                   }
                   if (ar !=0)
                   {
                       Command.Connection.Close();

                       return true;
                   }
                   Command.Connection.Close();
                   return false;

               }
               catch (Exception ex)
               {
                   //MessageBox.Show(ex.Message);
                   return false;

               }
           }
        public static Boolean CheackUniqKode(Int32 article)
        {
            try
            {
                Int32 ar = 0;
                string cmd = "SELECT count(*) FROM trade1.order where kode = " + article + ";";
                MySqlCommand Command = new MySqlCommand(cmd, Connect());
                MySqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    ar = Convert.ToInt32(reader[0].ToString());
                }
                if (ar != 0)
                {
                    Command.Connection.Close();

                    return true;
                }
                Command.Connection.Close();
                return false;

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return false;

            }
        }
      
        public static void AddNewOrder(string DeloveryDate, string FIO, string OrderDate, string OrderProduct, Int32 kode, string address, DataGridView datagrid)
        {
            try
            {

                var result = MessageBox.Show("Вы уверены, что хотите добавить новый заказ?", "Предупреждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string cmd = "INSERT INTO `trade1`.`order` (`OrderID`, `OrderStatus`, `OrderDeliveryDate`, `OrderPickupPoint`,"+
                                 "`OrderDate`, `OrderProduct`, `kode`, `User`) VALUES "+
                                 "(null,"+
                                 "'Новый', "+
                                 "'"+DeloveryDate+"',"+
                                 "(select `idOrderPickupPoint` from `orderpickuppoint` where  addres ='"+address+"'), "+
                                 "'"+OrderDate+"',"+
                                 "'" + OrderProduct + "', " +
                                 "'"+kode+"', "+
                                 "(select `user`.`UserID` from `user` where  concat(UserSurname,' ',UserName,' ',UserPatronymic) ='"+FIO+"'));";

                    MySqlCommand Command = new MySqlCommand(cmd, Connect());
                    Command.ExecuteNonQuery();
                    Command.Connection.Close();

                    SQLClass.SelectOrderssInTable(datagrid);

                    MessageBox.Show("Данные успешно добавлены.", "Информация");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static string AddNewOrderTicket(string DeloveryDate, string FIO, string OrderDate, string OrderProduct, Int32 kode, string address)
        {
            try
            {

              
                    string cmd = "INSERT INTO `trade1`.`order` (`OrderID`, `OrderStatus`, `OrderDeliveryDate`, `OrderPickupPoint`," +
                                 "`OrderDate`, `OrderProduct`, `kode`, `User`) VALUES " +
                                 "(null," +
                                 "'Новый', " +
                                 "'" + DeloveryDate + "'," +
                                 "(select `idOrderPickupPoint` from `orderpickuppoint` where  addres ='" + address + "'), " +
                                 "'" + OrderDate + "'," +
                                 "'" + OrderProduct + "', " +
                                 "'" + kode + "', " +
                                 "(select `user`.`UserID` from `user` where  concat(UserSurname,' ',UserName,' ',UserPatronymic) ='" + FIO + "'));";

                    MySqlCommand Command = new MySqlCommand(cmd, Connect());
                    Command.ExecuteNonQuery();
                    Command.Connection.Close();
                    string id ="";
                    cmd = "SELECT OrderID FROM `trade1`.`order` WHERE kode ='"+kode+"';";
                    MySqlCommand Command1 = new MySqlCommand(cmd, Connect());

                    MySqlDataReader Reader = Command1.ExecuteReader();
                while (Reader.Read()){
                id+=Reader[0];
                }
                    Command1.Connection.Close();

                    return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "error";
            }

        }
        public static void UpdeateSelectedOrder(string OrderStatus, string OrderDeliveryDate,string address, string FIO,
            string OrderDate,string OrderProduct,string kode, string id, DataGridView datagrid)
        {
            try
            {
                var result = MessageBox.Show("Вы уверены, что хотите изменить данные выделенного продукта?", "Предупреждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string cmd = "UPDATE `trade1`.`order` SET `OrderStatus` = '"+OrderStatus+
                    "', `OrderDeliveryDate` = '"+OrderDeliveryDate+"', `OrderPickupPoint` = (select `idOrderPickupPoint` from `orderpickuppoint` where  addres ='"+address+"')"+
                    ", `OrderDate` = '"+OrderDate+"', `OrderProduct` = '"+OrderProduct+"', `kode` = '"+kode+
                    "', `User` = (select `user`.`UserID` from `user` where  concat(UserSurname,' ',UserName,' ',UserPatronymic) ='"+FIO+"') WHERE (`OrderID` = '"+id+"');";

                    MySqlCommand Command = new MySqlCommand(cmd, Connect());
                    Command.ExecuteNonQuery();
                    Command.Connection.Close();

                    SelectOrderssInTable(datagrid);
                    MessageBox.Show("Данные успешно изменены.", "Информация");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}
