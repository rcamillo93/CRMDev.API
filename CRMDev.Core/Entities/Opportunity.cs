﻿using CRMDev.Core.Enums;

namespace CRMDev.Core.Entities
{
    public class Opportunity : BaseEntity
    {
        public Opportunity(string title, string description, DateTime term, decimal budget, string scope,
            bool support, OpportunityStatusEnum statusEnum, string reasonLoss, OpportunityStagesEnum step, int idContact)
        {
            Title = title;
            Description = description;
            Term = term;
            Budget = budget;
            Scope = scope;
            Support = support;
            StatusEnum = statusEnum;
            ReasonLoss = reasonLoss;
            Step = step;
            IdContact = idContact;

            CreatedAt = DateTime.UtcNow;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime Term { get; private set; }        
        public decimal Budget { get; private set; }
        public string Scope { get; private set; }
        public bool Support { get; private set; }
        public OpportunityStatusEnum StatusEnum { get; private set; }
        public string ReasonLoss { get; private set; }
        public OpportunityStagesEnum Step { get; private set; }
        public int IdContact { get; private set; }
        public Contact Contact { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
