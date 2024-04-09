using BloodTypeWeb.Areas.Identity.Data;
using BloodTypeWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BloodTypeWeb.Data;

public class BloodTypeDbContext : IdentityDbContext<ApplicationUser>
{
    public BloodTypeDbContext(DbContextOptions<BloodTypeDbContext> options)
        : base(options)
    {

    }
    public DbSet<BloodType> BloodTypes { get; set; }
    public DbSet<RhFactor> RhFactors { get; set; }
    public DbSet<ParentCombinationRh> ParentCombinationsRh { get; set; }
    public DbSet<ChildOutcomeRh> ChildOutcomesRh { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<BloodType>().HasData(
        new BloodType { BloodTypeID = "O", BloodTypeName = "O" },
        new BloodType { BloodTypeID = "A", BloodTypeName = "A" },
        new BloodType { BloodTypeID = "B", BloodTypeName = "B" },
        new BloodType { BloodTypeID = "AB", BloodTypeName = "AB" }
    );
        builder.Entity<RhFactor>().HasData(
        new RhFactor { RhFactorID = 1, RhFactorType = "+" },
        new RhFactor { RhFactorID = 2, RhFactorType = "-" }
    );
        builder.Entity<ParentCombinationRh>().HasData(
    new { CombinationID = 1, MotherBloodTypeID = "O", FatherBloodTypeID = "O", MotherRhFactorID = 1, FatherRhFactorID = 2 },
    new { CombinationID = 2, MotherBloodTypeID = "O", FatherBloodTypeID = "O", MotherRhFactorID = 2, FatherRhFactorID = 1 },
    new { CombinationID = 3, MotherBloodTypeID = "O", FatherBloodTypeID = "O", MotherRhFactorID = 1, FatherRhFactorID = 1 },
    new { CombinationID = 4, MotherBloodTypeID = "O", FatherBloodTypeID = "O", MotherRhFactorID = 2, FatherRhFactorID = 2 },

    new { CombinationID = 5, MotherBloodTypeID = "O", FatherBloodTypeID = "A", MotherRhFactorID = 1, FatherRhFactorID = 2 },
    new { CombinationID = 6, MotherBloodTypeID = "O", FatherBloodTypeID = "A", MotherRhFactorID = 2, FatherRhFactorID = 1 },
    new { CombinationID = 7, MotherBloodTypeID = "O", FatherBloodTypeID = "A", MotherRhFactorID = 1, FatherRhFactorID = 1 },
    new { CombinationID = 8, MotherBloodTypeID = "O", FatherBloodTypeID = "A", MotherRhFactorID = 2, FatherRhFactorID = 2 },

    new { CombinationID = 9, MotherBloodTypeID = "O", FatherBloodTypeID = "B", MotherRhFactorID = 1, FatherRhFactorID = 2 },
    new { CombinationID = 10, MotherBloodTypeID = "O", FatherBloodTypeID = "B", MotherRhFactorID = 2, FatherRhFactorID = 1 },
    new { CombinationID = 11, MotherBloodTypeID = "O", FatherBloodTypeID = "B", MotherRhFactorID = 1, FatherRhFactorID = 1 },
    new { CombinationID = 12, MotherBloodTypeID = "O", FatherBloodTypeID = "B", MotherRhFactorID = 2, FatherRhFactorID = 2 },

    new { CombinationID = 13, MotherBloodTypeID = "O", FatherBloodTypeID = "AB", MotherRhFactorID = 1, FatherRhFactorID = 2 },
    new { CombinationID = 14, MotherBloodTypeID = "O", FatherBloodTypeID = "AB", MotherRhFactorID = 2, FatherRhFactorID = 1 },
    new { CombinationID = 15, MotherBloodTypeID = "O", FatherBloodTypeID = "AB", MotherRhFactorID = 1, FatherRhFactorID = 1 },
    new { CombinationID = 16, MotherBloodTypeID = "O", FatherBloodTypeID = "AB", MotherRhFactorID = 2, FatherRhFactorID = 2 },

    new { CombinationID = 17, MotherBloodTypeID = "A", FatherBloodTypeID = "A", MotherRhFactorID = 1, FatherRhFactorID = 2 },
    new { CombinationID = 18, MotherBloodTypeID = "A", FatherBloodTypeID = "A", MotherRhFactorID = 2, FatherRhFactorID = 1 },
    new { CombinationID = 19, MotherBloodTypeID = "A", FatherBloodTypeID = "A", MotherRhFactorID = 1, FatherRhFactorID = 1 },
    new { CombinationID = 20, MotherBloodTypeID = "A", FatherBloodTypeID = "A", MotherRhFactorID = 2, FatherRhFactorID = 2 },

    new { CombinationID = 21, MotherBloodTypeID = "A", FatherBloodTypeID = "O", MotherRhFactorID = 1, FatherRhFactorID = 2 },
    new { CombinationID = 22, MotherBloodTypeID = "A", FatherBloodTypeID = "O", MotherRhFactorID = 2, FatherRhFactorID = 1 },
    new { CombinationID = 23, MotherBloodTypeID = "A", FatherBloodTypeID = "O", MotherRhFactorID = 1, FatherRhFactorID = 1 },
    new { CombinationID = 24, MotherBloodTypeID = "A", FatherBloodTypeID = "O", MotherRhFactorID = 2, FatherRhFactorID = 2 },

    new { CombinationID = 25, MotherBloodTypeID = "A", FatherBloodTypeID = "B", MotherRhFactorID = 1, FatherRhFactorID = 2 },
    new { CombinationID = 26, MotherBloodTypeID = "A", FatherBloodTypeID = "B", MotherRhFactorID = 2, FatherRhFactorID = 1 },
    new { CombinationID = 27, MotherBloodTypeID = "A", FatherBloodTypeID = "B", MotherRhFactorID = 1, FatherRhFactorID = 1 },
    new { CombinationID = 28, MotherBloodTypeID = "A", FatherBloodTypeID = "B", MotherRhFactorID = 2, FatherRhFactorID = 2 },

    new { CombinationID = 29, MotherBloodTypeID = "A", FatherBloodTypeID = "AB", MotherRhFactorID = 1, FatherRhFactorID = 2 },
    new { CombinationID = 30, MotherBloodTypeID = "A", FatherBloodTypeID = "AB", MotherRhFactorID = 2, FatherRhFactorID = 1 },
    new { CombinationID = 31, MotherBloodTypeID = "A", FatherBloodTypeID = "AB", MotherRhFactorID = 1, FatherRhFactorID = 1 },
    new { CombinationID = 32, MotherBloodTypeID = "A", FatherBloodTypeID = "AB", MotherRhFactorID = 2, FatherRhFactorID = 2 },

    new { CombinationID = 33, MotherBloodTypeID = "B", FatherBloodTypeID = "B", MotherRhFactorID = 1, FatherRhFactorID = 2 },
    new { CombinationID = 34, MotherBloodTypeID = "B", FatherBloodTypeID = "B", MotherRhFactorID = 2, FatherRhFactorID = 1 },
    new { CombinationID = 35, MotherBloodTypeID = "B", FatherBloodTypeID = "B", MotherRhFactorID = 1, FatherRhFactorID = 1 },
    new { CombinationID = 36, MotherBloodTypeID = "B", FatherBloodTypeID = "B", MotherRhFactorID = 2, FatherRhFactorID = 2 },

    new { CombinationID = 37, MotherBloodTypeID = "B", FatherBloodTypeID = "O", MotherRhFactorID = 1, FatherRhFactorID = 2 },
    new { CombinationID = 38, MotherBloodTypeID = "B", FatherBloodTypeID = "O", MotherRhFactorID = 2, FatherRhFactorID = 1 },
    new { CombinationID = 39, MotherBloodTypeID = "B", FatherBloodTypeID = "O", MotherRhFactorID = 1, FatherRhFactorID = 1 },
    new { CombinationID = 40, MotherBloodTypeID = "B", FatherBloodTypeID = "O", MotherRhFactorID = 2, FatherRhFactorID = 2 },

    new { CombinationID = 41, MotherBloodTypeID = "B", FatherBloodTypeID = "A", MotherRhFactorID = 1, FatherRhFactorID = 2 },
    new { CombinationID = 42, MotherBloodTypeID = "B", FatherBloodTypeID = "A", MotherRhFactorID = 2, FatherRhFactorID = 1 },
    new { CombinationID = 43, MotherBloodTypeID = "B", FatherBloodTypeID = "A", MotherRhFactorID = 1, FatherRhFactorID = 1 },
    new { CombinationID = 44, MotherBloodTypeID = "B", FatherBloodTypeID = "A", MotherRhFactorID = 2, FatherRhFactorID = 2 },

    new { CombinationID = 45, MotherBloodTypeID = "B", FatherBloodTypeID = "AB", MotherRhFactorID = 1, FatherRhFactorID = 2 },
    new { CombinationID = 46, MotherBloodTypeID = "B", FatherBloodTypeID = "AB", MotherRhFactorID = 2, FatherRhFactorID = 1 },
    new { CombinationID = 47, MotherBloodTypeID = "B", FatherBloodTypeID = "AB", MotherRhFactorID = 1, FatherRhFactorID = 1 },
    new { CombinationID = 48, MotherBloodTypeID = "B", FatherBloodTypeID = "AB", MotherRhFactorID = 2, FatherRhFactorID = 2 },


    new { CombinationID = 49, MotherBloodTypeID = "AB", FatherBloodTypeID = "AB", MotherRhFactorID = 1, FatherRhFactorID = 2 },
    new { CombinationID = 50, MotherBloodTypeID = "AB", FatherBloodTypeID = "AB", MotherRhFactorID = 2, FatherRhFactorID = 1 },
    new { CombinationID = 51, MotherBloodTypeID = "AB", FatherBloodTypeID = "AB", MotherRhFactorID = 1, FatherRhFactorID = 1 },
    new { CombinationID = 52, MotherBloodTypeID = "AB", FatherBloodTypeID = "AB", MotherRhFactorID = 2, FatherRhFactorID = 2 },

    new { CombinationID = 53, MotherBloodTypeID = "AB", FatherBloodTypeID = "O", MotherRhFactorID = 1, FatherRhFactorID = 2 },
    new { CombinationID = 54, MotherBloodTypeID = "AB", FatherBloodTypeID = "O", MotherRhFactorID = 2, FatherRhFactorID = 1 },
    new { CombinationID = 55, MotherBloodTypeID = "AB", FatherBloodTypeID = "O", MotherRhFactorID = 1, FatherRhFactorID = 1 },
    new { CombinationID = 56, MotherBloodTypeID = "AB", FatherBloodTypeID = "O", MotherRhFactorID = 2, FatherRhFactorID = 2 },

    new { CombinationID = 57, MotherBloodTypeID = "AB", FatherBloodTypeID = "A", MotherRhFactorID = 1, FatherRhFactorID = 2 },
    new { CombinationID = 58, MotherBloodTypeID = "AB", FatherBloodTypeID = "A", MotherRhFactorID = 2, FatherRhFactorID = 1 },
    new { CombinationID = 59, MotherBloodTypeID = "AB", FatherBloodTypeID = "A", MotherRhFactorID = 1, FatherRhFactorID = 1 },
    new { CombinationID = 60, MotherBloodTypeID = "AB", FatherBloodTypeID = "A", MotherRhFactorID = 2, FatherRhFactorID = 2 },


    new { CombinationID = 61, MotherBloodTypeID = "AB", FatherBloodTypeID = "B", MotherRhFactorID = 1, FatherRhFactorID = 2 },
    new { CombinationID = 62, MotherBloodTypeID = "AB", FatherBloodTypeID = "B", MotherRhFactorID = 2, FatherRhFactorID = 1 },
    new { CombinationID = 63, MotherBloodTypeID = "AB", FatherBloodTypeID = "B", MotherRhFactorID = 1, FatherRhFactorID = 1 },
    new { CombinationID = 64, MotherBloodTypeID = "AB", FatherBloodTypeID = "B", MotherRhFactorID = 2, FatherRhFactorID = 2 }
);
        var childOutcomeId = 1; // Start with an ID for the outcomes
        builder.Entity<ChildOutcomeRh>().HasData(

            // O pos and O neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 1, ChildBloodTypeID = "O (100%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 1, ChildBloodTypeID = "O (100%)", ChildRhFactorID = 2, Probability = "50%" },
            // O neg and O pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 2, ChildBloodTypeID = "O (100%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 2, ChildBloodTypeID = "O (100%)", ChildRhFactorID = 2, Probability = "50%" },
            // O pos and O pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 3, ChildBloodTypeID = "O (100%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 3, ChildBloodTypeID = "O (100%)", ChildRhFactorID = 2, Probability = "6%" },
            // O neg and O neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 4, ChildBloodTypeID = "O (100%)", ChildRhFactorID = 2, Probability = "100%" },

            // O pos and A neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 5, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 5, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 5, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 5, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "50%" },
            // O neg and A pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 6, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 6, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 6, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 6, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "50%" },
            // O pos and A pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 7, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 7, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 7, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 7, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "6%" },
            // O neg and A pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 8, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 8, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "100%" },

            // O pos and B neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 9, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 9, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 9, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 9, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "50%" },
            // O neg and B pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 10, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 10, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 10, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 10, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "50%" },
            // O pos and B pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 11, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 11, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 11, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 11, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "6%" },
            // O neg and B neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 12, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 12, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "100%" },

            // O pos and AB neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 13, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 13, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 13, ChildBloodTypeID = "AB (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 13, ChildBloodTypeID = "AB (50%)", ChildRhFactorID = 2, Probability = "50%" },
            // O neg and AB pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 14, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 14, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 14, ChildBloodTypeID = "AB (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 14, ChildBloodTypeID = "AB (50%)", ChildRhFactorID = 2, Probability = "50%" },
            // O pos and AB pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 15, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 15, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 15, ChildBloodTypeID = "AB (50%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 15, ChildBloodTypeID = "AB (50%)", ChildRhFactorID = 2, Probability = "6%" },
            // O neg and AB neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 16, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 16, ChildBloodTypeID = "AB (50%)", ChildRhFactorID = 2, Probability = "100%" },

             // A pos and A neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 17, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 17, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 17, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 17, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "50%" },
            // A neg and A pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 18, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 18, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 18, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 18, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "50%" },
            // A pos and A pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 19, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 19, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 19, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 19, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "6%" },
            // A neg and A neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 20, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 20, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "100%" },

            // A pos and O neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 21, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 21, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 21, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 21, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "50%" },
            // A neg and O pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 22, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 22, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 22, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 22, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "50%" },
            // A pos and O pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 23, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 23, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 23, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 23, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "6%" },
            // A neg and O neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 24, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 24, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "100%" },

            // A pos and B neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 25, ChildBloodTypeID = "O (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 25, ChildBloodTypeID = "O (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 25, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 25, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 25, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 25, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 25, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 25, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "50%" },
            // A neg and B pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 26, ChildBloodTypeID = "O (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 26, ChildBloodTypeID = "O (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 26, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 26, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 26, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 26, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 26, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 26, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "50%" },
            // A pos and B pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 27, ChildBloodTypeID = "O (25%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 27, ChildBloodTypeID = "O (25%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 27, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 27, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 27, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 27, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 27, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 27, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "6%" },
            // A neg and B neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 28, ChildBloodTypeID = "O (25%)", ChildRhFactorID = 2, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 28, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 2, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 28, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 1, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 28, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "100%" },

            // A pos and AB neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 29, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 29, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 29, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 29, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 29, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 29, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "50%" },
           // A neg and AB pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 30, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 30, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 30, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 30, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 30, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 30, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "50%" },
            // A pos and AB pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 31, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 31, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 31, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 31, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 31, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 31, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "6%" },
            // A neg and AB neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 32, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 32, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 2, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 32, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "100%" },

            // B pos and B neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 33, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 33, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 33, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 33, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "50%" },
            // B neg and B pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 34, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 34, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 34, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 34, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "50%" },
            // B pos and B pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 35, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 35, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 35, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 35, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "6%" },
            // B neg and B neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 36, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 36, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "100%" },

            // B pos and O neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 37, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 37, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 37, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 37, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "50%" },
            // B neg and O pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 38, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 38, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 38, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 38, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "50%" },
            // B pos and O pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 39, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 39, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 39, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 39, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "6%" },
            // B neg and O neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 40, ChildBloodTypeID = "O (50%)", ChildRhFactorID = 2, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 40, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "100%" },

            // B pos and A neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 41, ChildBloodTypeID = "O (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 41, ChildBloodTypeID = "O (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 41, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 41, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 41, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 41, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 41, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 41, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "50%" },
            // B neg and A pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 42, ChildBloodTypeID = "O (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 42, ChildBloodTypeID = "O (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 42, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 42, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 42, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 42, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 42, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 42, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "50%" },
            // B pos and A pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 43, ChildBloodTypeID = "O (25%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 43, ChildBloodTypeID = "O (25%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 43, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 43, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 43, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 43, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 43, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 43, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "6%" },
            // B neg and A neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 44, ChildBloodTypeID = "O (25%)", ChildRhFactorID = 2, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 44, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 2, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 44, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 1, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 44, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "100%" },

            // B pos and AB neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 45, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 45, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 45, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 45, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 45, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 45, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "50%" },
            // B neg and AB pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 46, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 46, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 46, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 46, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 46, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 46, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "50%" },
            // B pos and AB pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 47, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 47, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 47, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 47, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 47, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 47, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "6%" },
            // B neg and AB neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 48, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 2, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 48, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 48, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "100%" },

            // AB pos and AB neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 49, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 49, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 49, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 49, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 49, ChildBloodTypeID = "AB (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 49, ChildBloodTypeID = "AB (50%)", ChildRhFactorID = 2, Probability = "50%" },
            // AB neg and AB pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 50, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 50, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 50, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 50, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 50, ChildBloodTypeID = "AB (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 50, ChildBloodTypeID = "AB (50%)", ChildRhFactorID = 2, Probability = "50%" },
            // AB pos and AB pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 51, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 51, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 51, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 51, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 51, ChildBloodTypeID = "AB (50%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 51, ChildBloodTypeID = "AB (50%)", ChildRhFactorID = 2, Probability = "6%" },
            // AB neg and AB neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 52, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 2, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 52, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 2, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 52, ChildBloodTypeID = "AB (50%)", ChildRhFactorID = 2, Probability = "100%" },

            // AB pos and O neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 53, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 53, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 53, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 53, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "50%" },
            // AB neg and O pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 54, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 54, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 54, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 54, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "50%" },
            // AB pos and O pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 55, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 55, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 55, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 55, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "6%" },
            // AB neg and O pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 56, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 56, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "100%" },

            // AB pos and A neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 57, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 57, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 57, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 57, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 57, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 57, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "50%" },
            // AB neg and A pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 58, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 58, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 58, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 58, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 58, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 58, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "50%" },
            // AB pos and A pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 59, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 59, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 59, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 59, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 59, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 59, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "6%" },
            // AB neg and A neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 60, ChildBloodTypeID = "A (50%)", ChildRhFactorID = 2, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 60, ChildBloodTypeID = "B (25%)", ChildRhFactorID = 2, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 60, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "100%" },

            // AB pos and B neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 61, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 61, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 61, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 61, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 61, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 61, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "50%" },
            // AB neg and B pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 62, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 62, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 62, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 62, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 62, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 1, Probability = "50%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 62, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "50%" },
            // AB pos and B pos
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 63, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 63, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 63, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 63, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "6%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 63, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 1, Probability = "94%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 63, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "6%" },
            // AB neg and B neg
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 64, ChildBloodTypeID = "A (25%)", ChildRhFactorID = 2, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 64, ChildBloodTypeID = "B (50%)", ChildRhFactorID = 2, Probability = "100%" },
            new ChildOutcomeRh { OutcomeID = childOutcomeId++, CombinationID = 64, ChildBloodTypeID = "AB (25%)", ChildRhFactorID = 2, Probability = "100%" }


























        );


        // Configure the relationship for MotherCombinations
        builder.Entity<ParentCombinationRh>()
            .HasOne<BloodType>(p => p.MotherBloodType)
            .WithMany(b => b.MotherCombinations)
            .HasForeignKey(p => p.MotherBloodTypeID)
            .OnDelete(DeleteBehavior.Restrict);

        // Configure the relationship for FatherCombinations
        builder.Entity<ParentCombinationRh>()
            .HasOne<BloodType>(p => p.FatherBloodType)
            .WithMany(b => b.FatherCombinations)
            .HasForeignKey(p => p.FatherBloodTypeID)
            .OnDelete(DeleteBehavior.Restrict);

        // Corrected: Configure the relationship for FatherRhFactor
        builder.Entity<ParentCombinationRh>()
            .HasOne<RhFactor>(p => p.FatherRhFactor) // Correctly specifies the entity type
            .WithMany(b => b.FatherCombinations) // Assuming RhFactor doesn't have a navigation property back to ParentCombinationRh; adjust as necessary
            .HasForeignKey(p => p.FatherRhFactorID)
            .OnDelete(DeleteBehavior.Restrict);


        // Configure the relationship for MotherRhFactor
        builder.Entity<ParentCombinationRh>()
            .HasOne<RhFactor>(p => p.MotherRhFactor) // Navigation property in ParentCombinationRh for MotherRhFactor
            .WithMany(b => b.MotherCombinations) // If RhFactor does not have a navigation property back to ParentCombinationRh
            .HasForeignKey(p => p.MotherRhFactorID)
            .OnDelete(DeleteBehavior.Restrict);

       


    }

}
