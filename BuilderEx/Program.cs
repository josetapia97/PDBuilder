using BuilderEx;
//5


//se crea una instancia de la interfaz(objeto responsable de crear las partes)
IRobotBuilder robotBuilder = new RobotBuilder();
//se crea el director (supervisa la logica pero delega cada parte)
RobotDirector robotDirector = new RobotDirector(robotBuilder);
//ConstructRobot() inicia el proceso de construccion, con metodos especificos definidos
robotDirector.ConstructRobot();
//Devuelve la instancia de Robot que ha sido construida
Robot robot = robotBuilder.GetRobot();
//Se muestran los datos
robot.DisplayRobotInfo();