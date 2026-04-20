
using ClasesStructsRecords.Clases;

Carro carro1 = new Carro();
carro1.Acelerar();
carro1.ImprimirDetalles();


//Si no se asigna el tipo de una variable que instancia una clase, se puede asignar null ya que las clases se asignan por referencia.
var carro2 = new Carro();
carro2 = null;

var carro3 = new Carro(mark: "Dodge");
carro3.ImprimirDetalles();