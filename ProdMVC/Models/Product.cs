using System.ComponentModel.DataAnnotations;
namespace ProdMVC.Models;
public class Product
{
    [Display(Name="Product Id")]
    [Key]
    [Required(ErrorMessage="Id is Compulsary")]
    public int Id{get;set;}
    [Required(ErrorMessage="Name Cannot be blank")]
    public string ?Name{get;set;}
    [Range(1000,90000,ErrorMessage="Price should be between 100 and 900")]
    public int Price{get;set;}
    public int Stock{get;set;}
}