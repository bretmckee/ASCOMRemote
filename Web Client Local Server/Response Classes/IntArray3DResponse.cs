﻿using System;

namespace ASCOM.Web
{
    public class IntArray3DResponse : ImageArrayResponseBase
    {
        private int[,,] intArray3D;

        private const int RANK = 3;
        private const SharedConstants.ImageArrayElementTypes TYPE = SharedConstants.ImageArrayElementTypes.Int;

        public IntArray3DResponse(int clientTransactionID, int transactionID, string method)
        {
            base.ServerTransactionID = transactionID;
            base.Method = method;
            base.ClientTransactionID = clientTransactionID;
        }

        public int[,,] Value
        {
            get { return intArray3D; }
            set
            {
                intArray3D = value;
                base.Type = (int)TYPE;
                base.Rank = RANK;
            }
        }
    }
}