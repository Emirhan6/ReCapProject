﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        public IResult Payment()
        {
            return new SuccessResult(Messages.SuccessfulPayment);
        }
    }
}
