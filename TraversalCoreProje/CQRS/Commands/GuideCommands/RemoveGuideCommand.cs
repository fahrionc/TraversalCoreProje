﻿using MediatR;

namespace TraversalCoreProje.CQRS.Commands.GuideCommands
{
    public class RemoveGuideCommand : IRequest
    {
        public RemoveGuideCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
