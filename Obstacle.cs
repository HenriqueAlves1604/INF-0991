public class Obstacle {
    //Atributos ALTERADOR1, ALTERADOR2 e ALTERADOR3
    private string type {get; set;}
    private int xPosition {get; set;}
    private int yPosition {get; set;}

    //Outra alteracao realizada por ALTERADOR1, ALTERADOR2 e ALTERADOR3
    //Constructor:
    Obstacle(string type, int xPosition, int yPosition){
	this.type = type;
	this.xPosition = xPosition;
	this.yPosition = yPosition;
    }
}
