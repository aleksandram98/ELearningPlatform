﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Data.UnitOfWork
{
    public interface IUnitOfWork: IDisposable //omogucava pristup svim interfejsima
    {
        public IRepositoryKurs Kurs { get; set; }
        public IRepositoryTest Test { get; set; }
        public IRepositoryKorisnik Korisnik { get; set; }
        void Commit();
    }
}