using System;

namespace Cocos2D.CCBReader
{
    public interface ICCBMemberVariableAssigner
    {
        bool OnAssignCCBMemberVariable(object target, string memberVariableName, CCNode node);

        bool OnAssignCCBCustomProperty(Object pTarget, string pMemberVariableName, CCBValue pCCBValue);
    }
}