## Status: archived

# Valremsharca Proxy

.. or also called:

- Validation
- Remote
- Sharding
- Caching
- Proxy

This was an attempt at combining all of these - and more - properties into a cluster control system.

## Remote Proxy

This component is a fouding member of the entire infrastructure. it assures the ability to transition control flow across multiple devices. Due to this measure other properties like validation, caching and sharding can be inforced.

## Sharding

Sharding only became a viable option, after remote proxing made it simple to install middleware in between device computations. Therefore ballancing load accross a cluster of similar nodes became a trivial addition.

## Caching

A caching layer is, just like sharding, a trivial addition, whenever middleware is an option. In order to avoid the possibility of cache misses another layer of middleware has been established:

### Observability of actions

Every single action can be assigned to one of these categories:

- Assignments
- Reads
- Calculations
- ?

Manually assigning these categories to every single action might be time consuming though. Here Injection can be used to avoid this effort.

## Injection

To avoid unnecessary labour, proxying can be injected into the specific kind of business logic. This can be achieved in dotnet through manual IL inserts or a runtime patcher like https://github.com/pardeike/Harmony

## Cluster Controller

In order to correctly manage nodes and pods running businesslogic with injected, their identity needs to be clarified. The cluster controller is responsible for scheduling new instances and clearing up other ones. Therfore setting environment variables on spawned instances is the simplest approach here.

## Subscribtion Based Communication

Network floods might be expected, when considering the amount of cross api communication. In order to eliminate this problem a subscribtion based communcation system can be inplemented.

After code execution stops because of an external resource dependency, an api listens for incoming http traffic. Because the external dependency receives the requesters identity, a response can asynchronously be returned as soon as code execution completed on the responding node.

This essentially resembles a long polling solution instead of a constant stream of repeated requests.
