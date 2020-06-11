using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCom.Entity
{
    public class SingleApp
    {
        private SingleApp()
        {
            this._id = Guid.NewGuid().ToString();
        }

        private string _id;
        private static SingleApp _instance;

        public string Id { get => _id; private set => _id = value; }

        public static SingleApp CreateApp()
        {
            if (_instance == null)
                _instance = new SingleApp();
            return _instance;
        }
    }
}
