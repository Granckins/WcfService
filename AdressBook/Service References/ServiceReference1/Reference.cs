//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.17929
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

// Исходное имя файла:
// Дата создания: 12.03.2016 22:17:16
namespace AdressBook.ServiceReference1
{
    
    /// <summary>
    /// В схеме отсутствуют комментарии для AdressDBEntities.
    /// </summary>
    public partial class AdressDBEntities : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Инициализируйте новый объект AdressDBEntities.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public AdressDBEntities(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::System.Data.Services.Common.DataServiceProtocolVersion.V3)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Поскольку пространство имен, настроенное для этой ссылки на службу
        /// в Visual Studio, отличается от пространства имен, указанного
        /// в схеме сервера, для сопоставления этих пространств имен используйте преобразователи типов.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("AdressDBModel", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("AdressBook.ServiceReference1", typeName.Substring(13)), false);
            }
            return null;
        }
        /// <summary>
        /// Поскольку пространство имен, настроенное для этой ссылки на службу
        /// в Visual Studio, отличается от пространства имен, указанного
        /// в схеме сервера, для сопоставления этих пространств имен используйте преобразователи типов.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("AdressBook.ServiceReference1", global::System.StringComparison.Ordinal))
            {
                return string.Concat("AdressDBModel.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// В схеме отсутствуют комментарии для Table.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Table> Table
        {
            get
            {
                if ((this._Table == null))
                {
                    this._Table = base.CreateQuery<Table>("Table");
                }
                return this._Table;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Table> _Table;
        /// <summary>
        /// В схеме отсутствуют комментарии для Table.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToTable(Table table)
        {
            base.AddObject("Table", table);
        }
    }
    /// <summary>
    /// В схеме отсутствуют комментарии для AdressDBModel.Table.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Table")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class Table : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Создайте новый объект Table.
        /// </summary>
        /// <param name="ID">Начальное значение Id.</param>
        /// <param name="fIO">Начальное значение FIO.</param>
        /// <param name="phone">Начальное значение Phone.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Table CreateTable(int ID, string fIO, string phone)
        {
            Table table = new Table();
            table.Id = ID;
            table.FIO = fIO;
            table.Phone = phone;
            return table;
        }
        /// <summary>
        /// В схеме отсутствуют комментарии для свойства Id.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// В схеме отсутствуют комментарии для свойства FIO.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string FIO
        {
            get
            {
                return this._FIO;
            }
            set
            {
                this.OnFIOChanging(value);
                this._FIO = value;
                this.OnFIOChanged();
                this.OnPropertyChanged("FIO");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _FIO;
        partial void OnFIOChanging(string value);
        partial void OnFIOChanged();
        /// <summary>
        /// В схеме отсутствуют комментарии для свойства Phone.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Phone
        {
            get
            {
                return this._Phone;
            }
            set
            {
                this.OnPhoneChanging(value);
                this._Phone = value;
                this.OnPhoneChanged();
                this.OnPropertyChanged("Phone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Phone;
        partial void OnPhoneChanging(string value);
        partial void OnPhoneChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}