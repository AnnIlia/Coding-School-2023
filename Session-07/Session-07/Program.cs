// See https://aka.ms/new-console-template for more information
using MySession_07;
using static MySession_07.MessageLogger;

//firtly i did it with project name "MySession_07"

//part 3
ActionRequest request = new ActionRequest();
ActionResponse response= new ActionResponse();

ActionResolver resolver= new ActionResolver();

response = resolver.Execute(request);



