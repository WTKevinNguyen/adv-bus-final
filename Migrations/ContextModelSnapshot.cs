﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using adv_bus_final.Models;

#nullable disable

namespace adv_bus_final.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("adv_bus_final.Models.Rating", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("RatingValue")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RecipeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("RatingId");

                    b.HasIndex("RecipeId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("adv_bus_final.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ingrediants")
                        .HasColumnType("TEXT");

                    b.Property<string>("Instructions")
                        .HasColumnType("TEXT");

                    b.Property<string>("Length")
                        .HasColumnType("TEXT");

                    b.Property<int?>("RecipesRecipeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("RecipeId");

                    b.HasIndex("RecipesRecipeId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("adv_bus_final.Models.Rating", b =>
                {
                    b.HasOne("adv_bus_final.Models.Recipe", "Recipes")
                        .WithMany("Ratings")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("adv_bus_final.Models.Recipe", b =>
                {
                    b.HasOne("adv_bus_final.Models.Recipe", "Recipes")
                        .WithMany()
                        .HasForeignKey("RecipesRecipeId");

                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("adv_bus_final.Models.Recipe", b =>
                {
                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}