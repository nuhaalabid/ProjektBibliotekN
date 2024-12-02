﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applikation.Books.Commands.DeleteBook
{
    public class DeleteBookCommand : IRequest<bool>
    {
        public int BookId { get; }

        public DeleteBookCommand(int bookId)
        {
            BookId = bookId;
        }
    }
}

