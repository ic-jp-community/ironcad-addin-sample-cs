// CppWrapper.h : CppWrapper.DLL �̃��C�� �w�b�_�[ �t�@�C��
//

#pragma once

#ifndef __AFXWIN_H__
	#error "PCH �ɑ΂��Ă��̃t�@�C�����C���N���[�h����O�� 'stdafx.h' ���C���N���[�h���Ă�������"
#endif

#include "resource.h"		// ���C�� �V���{��


// CCppWrapperApp
// ���̃N���X�̎����Ɋւ��Ă� CppWrapper.cpp ���Q�Ƃ��Ă��������B
//

class CCppWrapperApp : public CWinApp
{
public:
	CCppWrapperApp();

// �I�[�o�[���C�h
public:
	virtual BOOL InitInstance();

	DECLARE_MESSAGE_MAP()
};
extern "C" {
	__declspec(dllexport) CWnd* HwndToCwnd(HWND* hwnd);
}
