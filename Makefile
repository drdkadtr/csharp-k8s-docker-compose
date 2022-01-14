all:
	kind create cluster --name csharp --config=kind.yaml

clean:
	kind delete clusters csharp
