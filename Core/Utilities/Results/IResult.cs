using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; } //Yapmaya calıstıgın ekleme ısı basarılı/basarısız
        string Message { get; }//Yapmaya calıstıgın ekleme ısı basarılı ıle ılgılı bılgılendırme
    }
}
