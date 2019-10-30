﻿using Feedback.Database.Models;
using Feedback.Web.Models;

namespace Feedback.UserInterface.Mappers
{
    public static class ReviewViewModelMapper
    {
        public static Review ToEntity(this ReviewViewModel vm)
        {
            return new Review()
            {
                ReviewId = vm.Id,
                ReviewRatingTypeId = vm.RatingId,
                Comment = vm.Comment,
            };
        }
    }
}
