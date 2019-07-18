﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using QuantBetChallenge.Infrastructure.Helpers;
using ValidationResult = QuantBetChallenge.Core.Validation.ValidationResult;

namespace QuantBetChallenge.Infrastructure.Validations.PinValidators
{
    public class CompleteConsecutiveNumberSequenceValidator : PinValidator, IValidator
    {
        public CompleteConsecutiveNumberSequenceValidator()
        {
        }

        public override ValidationResult Validate()
        {
            IPinForValidationDto pinForValidationDto = ValidationContext.ObjectInstance as IPinForValidationDto;

            if (pinForValidationDto == null)
                throw new Exception("Object for validation is null");

            int[] pinDigits = pinForValidationDto.Pin.Select(ch => ch - '0').ToArray();

            if (IsCompleteConsecutiveNumberSequence(pinDigits))
            {
                return new ValidationResult(false, "Pin in invalid. It is complete sequencial");
            }
                

            return new ValidationResult(true, null);
        }

        private bool IsCompleteConsecutiveNumberSequence(int[] digits)
        {
            bool isCompleteSequencial = true;

            for (int i = 0; i < digits.Length; i++)
            {
                if (i < digits.Length - 1)
                {
                    if (digits[i] + 1 != digits[i + 1])
                        isCompleteSequencial = false;
                }
            }

            return isCompleteSequencial;
        }
    }
}