# gRPCSpike
Demonstrate using gRPC : .Net Core Console App [Client] consumes gRPC Service and this service calls another service to get some information ..


.: What is gRPC?

   gRPC is an open-source remote procedure call (RPC) framework originally developed by Google in 2015 that can run anywhere.
   
   gRPC is a framework uses the HTTP/2 protocol to exchange binary messages,
   which are serialized/deserialized using Protocol Buffers — this is also designed by Google. 
   
   Basically, protocol buffers is a binary serialization protocol,
   it is highly performant by providing a compact binary format that requires low CPU usage.
   
   With gRPC, we also can call methods on a server application on a different machine as if were a local object.
   Nowadays, IoT applications are growing rapidly with a variety of devices/sensors and capabilities,
   especially small hardware specifications. gRPC becomes the first choice for communications between IoT devices.
   
   
   Another sample of using gRPC is with Microservice Architecture.
   When you choose to apply Microservice architecture, 
   it means that you will have to manage a lot of communications between service to service,
   client to service, service to 3rd party services …

   RESTful services are often useful for external-facing services, which are directly exposed to consumers.
   As RESTful service is based on conventional text-based messaging, 
   which are optimized for humans, these are not ideal choices for internal service-to-service communication. 
   
   In stead using RESTful services for internal communication (service to service), we can consider using gRPC.
   When we build multiple microservices with different technologies and programming languages, 
   it is important to have a standard way to define service interfaces and underlying message interchange formats.

   gRPC offers a clean and powerful way to specify service contracts using protocol buffers.
   
   
   
.: how it works!

   You can easily define the service contract by using the gRPC Interface Definition Language (IDL).
   In other words, as part of the service definition, 
   you can specify the methods that can be invoked remotely and the data structure of the parameters and return types.
   
   Note: The service contract is easy to understand and can be shared between the client and the service. 
         If there’s any change to the service contract, both the service and client-side code has to be regenerated.
   


.: gRPC supports four types of communications as below:

	. Unary RPC — the client sends a single request and gets back a single response.
	. Server streaming RPC — after getting request message from the client, the server sends back the stream of responses.
	. Client streaming RPC — where clients send a sequence of messages, wait for the server to process them and receive a single response back.
	. Bidirectional streaming RPC — client send a stream of messages to server and server sends back a stream of messages.
   
   

	1 — Create a gRPC service
	2 — Implement business logic for gRPC service
	3 — Running gRPC service
	4 — Implement gRPC Client Application
			Install-Package Grpc.Net.Client
			Install-Package Google.Protobuf
			Install-Package Grpc.Tools
			
	5 — Using Grpc.Net.ClientFactory to communicate between services
		Note: This scenario is very popular in Microservice Architecture when you need to make a call from service to service.
		Install the Grpc.Net.ClientFactory NuGet package
   
   
