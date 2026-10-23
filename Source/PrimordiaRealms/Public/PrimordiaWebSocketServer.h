#pragma once
#include "CoreMinimal.h"
#include "UObject/NoExportTypes.h"
#include "PrimordiaWebSocketServer.generated.h"

UCLASS()
class PRIMORDIAREALMS_API UPrimordiaWebSocketServer : public UObject
{
    GENERATED_BODY()

public:
    void StartServer();
};
