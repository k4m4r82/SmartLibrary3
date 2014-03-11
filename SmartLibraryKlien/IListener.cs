using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLibraryKlien
{
    public interface IListener
    {
        void Ok(bool addData, object[] data);
    }
}
