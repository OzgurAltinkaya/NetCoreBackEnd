﻿using System;
namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    public interface IResult
    {
        //get:okumak, set: yazmak
        bool Success { get; }
        string Message { get; }
    }
}
