using System;
using System.Collections.Generic;
using System.Text;
using BT_NangCao_TranMinhCanh.model;

namespace BT_NangCao_TranMinhCanh.ID
{
    public interface INewRepository
    {
        List<publisher> GetNews();
        void Save(List<publisher> publishers);
    }
}
