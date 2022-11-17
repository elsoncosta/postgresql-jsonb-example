using System.Xml;
// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using TesteJonB;
using TesteJonB.Models;

Console.WriteLine("Hello, World!");

// string json = @"{'Age':25,'Name':'Elson Costa','Orders':[{'OrderPrice':9,'ShippingAddress':'Someaddress1'},{'OrderPrice':23,'ShippingAddress':'Someaddress2'}]}";

// var entitys = JsonConvert.DeserializeObject<Customer>(json);

var entitys = new Customer();
entitys.permissao = new Permissao();
entitys.permissao.AbrirGaveta = true;
entitys.permissao.CancelamentoCupom = true;
entitys.permissao.CancelamentoItens = true;
entitys.permissao.DescontoCupom = true;

SomeEntity entity = new SomeEntity()
{
    Customer = entitys,
};

var jsonEntity = JsonConvert.SerializeObject(entity);
Console.WriteLine(jsonEntity);

 Context c = new Context();
 c.SomeEntities.Add(entity);
 c.SaveChanges();

 var listRet = c.SomeEntities.ToList();

 var first = listRet.LastOrDefault();
var jsonRetorno = JsonConvert.SerializeObject(first);
Console.WriteLine(jsonRetorno);
