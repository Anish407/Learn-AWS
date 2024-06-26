﻿using LearnAws.DynamoDb.Core.Entities;

namespace LearnAws.DynamoDb.Core.Repositories;

public interface ICustomersRepository: IRepository<Customers>
{
    Task<Customers> GetByEmail(string emailId);
}